using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Repositories;
using ProjectGasStation.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.Logging;

namespace ProjectGasStation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormGasStation>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

            container.RegisterType<DataContext>(new TransientLifetimeManager());
            container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
            container.RegisterType<ISellerRepository, SellerRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelSaleRepository, FuelSaleRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelSupplyRepository, FuelSupplyRepository>(new TransientLifetimeManager());

            return container;
        }

        private static LoggerFactory CreateLoggerFactory()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var serilogLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(serilogLogger, dispose: true);
            return loggerFactory;
        }
    }
}
