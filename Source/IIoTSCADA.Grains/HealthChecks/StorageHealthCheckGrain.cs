namespace IIoTSCADA.Grains.HealthChecks
{
    using System;
    using System.Threading.Tasks;
    using Orleans;
    using Orleans.Placement;
    using Orleans.Runtime;
    using IIoTSCADA.Abstractions.Grains.HealthChecks;

    [PreferLocalPlacement]
    public class StorageHealthCheckGrain : Grain<Guid>, IStorageHealthCheckGrain
    {
        public async Task CheckAsync()
        {
            try
            {
                this.State = Guid.NewGuid();
                await this.WriteStateAsync().ConfigureAwait(true);
                await this.ReadStateAsync().ConfigureAwait(true);
                await this.ClearStateAsync().ConfigureAwait(true);
            }
            finally
            {
                this.DeactivateOnIdle();
            }
        }
    }
}
