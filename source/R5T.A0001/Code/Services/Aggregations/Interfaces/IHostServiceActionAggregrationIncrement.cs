using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using R5T.L0017.D001;
using R5T.L0018.D001;
using R5T.T0063;


namespace R5T.A0001
{
    public interface IHostServiceActionAggregrationIncrement
    {
        IServiceAction<HostBuilderContext> HostBuilderContextAction { get; set; }
#pragma warning disable CS0618 // Type or member is obsolete
        IServiceAction<IApplicationLifetime> ApplicationLifetimeAction { get; set; }
#pragma warning restore CS0618 // Type or member is obsolete
        IServiceAction<IConfiguration> ConfigurationAction { get; set; }
        IServiceAction<IConfigureOptions<LoggerFilterOptions>> ConfigureLoggerFilterOptionsAction { get; set; }
        IServiceAction<IHost> HostAction { get; set; }
        IServiceAction<IHostApplicationLifetime> HostApplicationLifetimeAction { get; set; }
        IServiceAction<IHostEnvironment> HostEnvironmentAction { get; set; }
#pragma warning disable CS0618 // Type or member is obsolete
        IServiceAction<IHostingEnvironment> HostingEnvironmentAction { get; set; }
#pragma warning restore CS0618 // Type or member is obsolete
        IServiceAction<IHostLifetime> HostLifetimeAction { get; set; }
        IServiceAction<ILoggerUnbound> LoggerAction { get; set; }
        IServiceAction<ILoggerFactory> LoggerFactoryAction { get; set; }
        IServiceAction<IOptionsUnbound> OptionsAction { get; set; }
        IServiceAction<IOptionsFactoryUnbound> OptionsFactoryAction { get; set; }
        IServiceAction<IOptionsMonitorUnbound> OptionsMonitorAction { get; set; }
        IServiceAction<IOptionsMonitorCacheUnbound> OptionsMonitorCacheAction { get; set; }
        IServiceAction<IOptionsSnapshotUnbound> OptionsSnapshotUnbound { get; set; }
    }
}
