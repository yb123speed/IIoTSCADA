namespace IIoTSCADA.Grains
{
    using System.Threading.Tasks;
    using Orleans;
    using Orleans.Concurrency;
    using IIoTSCADA.Abstractions.Grains.HealthChecks;

    [StatelessWorker(1)]
    public class LocalHealthCheckGrain : Grain, ILocalHealthCheckGrain
    {
        public Task CheckAsync() => Task.CompletedTask;
    }
}
