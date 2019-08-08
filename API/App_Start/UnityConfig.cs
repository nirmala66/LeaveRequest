using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Common.Repositories;
using Common.Repositories.Interfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IHolidayRepository, HolidayRepository>();
            container.RegisterType<ILeaveHistoryRepository, LeaveHistoryRepository>();
            container.RegisterType<ILeaveRequestRepository, LeaveRequestRepository>();
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();

            container.RegisterType<IHolidayService, HolidayService>();
            container.RegisterType<ILeaveHistoryService, LeaveHistoryService>();
            container.RegisterType<ILeaveRequestService, LeaveRequestService>();
            container.RegisterType<IProvinceService, ProvinceService>();
            container.RegisterType<IVillageService, VillageService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}