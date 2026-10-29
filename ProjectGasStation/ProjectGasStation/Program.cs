using ProjectGasStation.Repositories;
using ProjectGasStation.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ProjectGasStation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormGasStation>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
            container.RegisterType<ISellerRepository, SellerRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelSaleRepository, FuelSaleRepository>(new TransientLifetimeManager());
            container.RegisterType<IFuelSupplyRepository, FuelSupplyRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}