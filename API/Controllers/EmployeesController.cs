using BusinessLogic.Services.Interfaces;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class EmployeesController : ApiController
    {
        readonly IEmployeeService _iEmployeeService;

        public EmployeesController() { }

        public EmployeesController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }

        // GET: api/Categories Get ALL
        public HttpResponseMessage GetEmployee()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in The Database");
            var get = _iEmployeeService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // GET: api/Categories/5 Get by ID
        public HttpResponseMessage GetCategories(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iEmployeeService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage InsertEmployee(EmployeeVM EmployeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iEmployeeService.Insert(EmployeeVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
    }
}