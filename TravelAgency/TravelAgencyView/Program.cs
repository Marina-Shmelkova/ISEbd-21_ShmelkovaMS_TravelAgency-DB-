//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BusinessLogics;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.Implements;
using Unity;
using Unity.Lifetime;

namespace TravelAgencyView
{
    static class Program
    {
        public static ClientViewModel Client { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new UnityContainer().AddExtension(new Diagnostic());
            Application.Run(container.Resolve<FormEntry>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IContractStorage, ContractStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientStorage, ClientStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IHotelStorage, HotelStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<INumberofhotelStorage, NumberofhotelStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRouteStorage, RouteStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITransportStorage, TransportStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITypeofnumberStorage, TypeofnumberStorage>(new
            HierarchicalLifetimeManager());

            currentContainer.RegisterType<ContractLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<HotelLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<NumberofhotelLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<RouteLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<TransportLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<TypeofnumberLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
