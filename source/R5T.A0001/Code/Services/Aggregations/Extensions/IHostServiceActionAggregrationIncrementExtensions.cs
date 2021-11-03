using System;


namespace R5T.A0001
{
    public static class IHostServiceActionAggregrationIncrementExtensions
    {
        public static T FilFrom<T>(this T aggregation,
            IHostServiceActionAggregrationIncrement other)
            where T : IHostServiceActionAggregrationIncrement
        {
            aggregation.ApplicationLifetimeAction = other.ApplicationLifetimeAction;
            aggregation.ConfigurationAction = other.ConfigurationAction;
            aggregation.ConfigureLoggerFilterOptionsAction = other.ConfigureLoggerFilterOptionsAction;
            aggregation.HostAction = other.HostAction;
            aggregation.HostApplicationLifetimeAction = other.HostApplicationLifetimeAction;
            aggregation.HostBuilderContextAction = other.HostBuilderContextAction;
            aggregation.HostEnvironmentAction = other.HostEnvironmentAction;
            aggregation.HostingEnvironmentAction = other.HostingEnvironmentAction;
            aggregation.HostLifetimeAction = other.HostLifetimeAction;
            aggregation.LoggerAction = other.LoggerAction;
            aggregation.LoggerFactoryAction = other.LoggerFactoryAction;
            aggregation.OptionsAction = other.OptionsAction;
            aggregation.OptionsFactoryAction = other.OptionsFactoryAction;
            aggregation.OptionsMonitorAction = other.OptionsMonitorAction;
            aggregation.OptionsMonitorCacheAction = other.OptionsMonitorCacheAction;
            aggregation.OptionsSnapshotUnbound = other.OptionsSnapshotUnbound;

            return aggregation;
        }
    }
}
