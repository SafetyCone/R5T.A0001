using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using R5T.L0017.D001;
using R5T.L0018.D001;
using R5T.T0062;


namespace R5T.A0001
{
    public static class IServiceActionExtensions
    {
        public static IHostServiceActionAggregration AddHostServiceActions(this IServiceAction _)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var applicationLifetimeAction = _.AddedElsewhere<IApplicationLifetime>();
            var configurationAction = _.AddedElsewhere<IConfiguration>();
            var configureLoggerFilterOptionsAction = _.AddedElsewhere<IConfigureOptions<LoggerFilterOptions>>();
            var hostAction = _.AddedElsewhere<IHost>();
            var hostApplicationLifetimeAction = _.AddedElsewhere<IHostApplicationLifetime>();
            var hostBuilderContextAction = _.AddedElsewhere<HostBuilderContext>();
            var hostEnvironmentAction = _.AddedElsewhere<IHostEnvironment>();
            var hostingEnvironmentAction = _.AddedElsewhere<IHostingEnvironment>();
            var hostLifetimeAction = _.AddedElsewhere<IHostLifetime>();
            var loggerAction = _.AddedElsewhere<ILoggerUnbound>();
            var loggerFactoryAction = _.AddedElsewhere<ILoggerFactory>();
            var optionsAction = _.AddedElsewhere<IOptionsUnbound>();
            var optionsFactoryAction = _.AddedElsewhere<IOptionsFactoryUnbound>();
            var optionsMonitorAction = _.AddedElsewhere<IOptionsMonitorUnbound>();
            var optionsMonitorCacheAction = _.AddedElsewhere<IOptionsMonitorCacheUnbound>();
            var optionsSnapshotAction = _.AddedElsewhere<IOptionsSnapshotUnbound>();
#pragma warning restore CS0618 // Type or member is obsolete

            var output = new HostServiceActionAggregration
            {
                ApplicationLifetimeAction = applicationLifetimeAction,
                ConfigurationAction = configurationAction,
                ConfigureLoggerFilterOptionsAction = configureLoggerFilterOptionsAction,
                HostAction = hostAction,
                HostApplicationLifetimeAction = hostApplicationLifetimeAction,
                HostBuilderContextAction = hostBuilderContextAction,
                HostEnvironmentAction = hostEnvironmentAction,
                HostingEnvironmentAction = hostingEnvironmentAction,
                HostLifetimeAction = hostLifetimeAction,
                LoggerAction = loggerAction,
                LoggerFactoryAction = loggerFactoryAction,
                OptionsAction = optionsAction,
                OptionsFactoryAction = optionsFactoryAction,
                OptionsMonitorAction = optionsMonitorAction,
                OptionsMonitorCacheAction = optionsMonitorCacheAction,
                OptionsSnapshotUnbound = optionsSnapshotAction,
            };

            return output;
        }
    }
}
