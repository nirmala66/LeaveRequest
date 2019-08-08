using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Common.Repositories;
using Common.Repositories.Interfaces;
<<<<<<< HEAD
using Common.Repository;
using Common.Repository.Interfaces;
=======
>>>>>>> remotes/origin/08Agustus
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

<<<<<<< HEAD
=======
            container.RegisterType<IParameterRepository, ParameterRepository>();
            container.RegisterType<IAvailableLeaveRepository, AvailableLeaveRepository>();
            container.RegisterType<IEmployeeStatusRepository, EmployeeStatusRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IParameterService, ParameterService>();
            container.RegisterType<IAvailableLeaveService, AvailableLeaveService>();
            container.RegisterType<IEmployeeStatusService, EmployeeStatusService>();
            container.RegisterType<IRegencyService, RegencyService>();

>>>>>>> remotes/origin/08Agustus
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

<<<<<<< HEAD
            container.RegisterType<IAvailableLeaveRepository, AvailableLeaveRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
            container.RegisterType<IDivisionRepository, DivisionRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IEmployeeStatusRepository, EmployeeStatusRepository>();
            container.RegisterType<IHolidayRepository, HolidayRepository>();
            container.RegisterType<ILeaveRequestRepository, LeaveRequestRepository>();
            container.RegisterType<ILoginRepository, LoginRepository>();
            container.RegisterType<IParameterRepository, ParameterRepository>();
            container.RegisterType<IPositionRepository, PositionRepository>();
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();

            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IDivisionService, DivisionService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<ILoginService, LoginService>();
            container.RegisterType<IPositionService, PositionService>();
            container.RegisterType<IRoleService, RoleService>();
=======

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
>>>>>>> remotes/origin/08Agustus

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}