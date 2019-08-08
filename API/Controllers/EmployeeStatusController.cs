using BusinessLogic.Services.Interfaces;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class EmployeeStatusController : ApiController
    {
        readonly IEmployeeStatusService _iEmployeeStatusService;
        public EmployeeStatusController() { }
        public EmployeeStatusController(IEmployeeStatusService iEmployeeStatusService)
        {
            _iEmployeeStatusService = iEmployeeStatusService;
        }

        // GET: api/EmployeeStatuss
        public HttpResponseMessage GetEmployeeStatuss()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iEmployeeStatusService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/EmployeeStatuss/5
        public HttpResponseMessage GetCompany(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iEmployeeStatusService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/EmployeeStatuss/5
        public HttpResponseMessage Update(int id, EmployeeStatusVM employeestatusVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iEmployeeStatusService.Update(id, employeestatusVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // PUT: api/Religions/5
        [HttpPut]
        public HttpResponseMessage UpdateEmployeeStatus(int id, EmployeeStatusVM employeestatusVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iEmployeeStatusService.Update(id, employeestatusVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Religions
        public HttpResponseMessage Insert(EmployeeStatusVM employeestatusVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong EmployeeStatus");
            var result = _iEmployeeStatusService.Insert(employeestatusVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Religions/5
        public HttpResponseMessage DeleteEmployeeStatus(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iEmployeeStatusService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}
