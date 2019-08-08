using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Common.Repositories;
using Common.Repositories.Interfaces;
using Common.Repository;
using Common.Repository.Interfaces;
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

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}