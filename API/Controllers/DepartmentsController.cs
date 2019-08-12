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
    public class DepartmentsController : ApiController
    {
        readonly IDepartmentService _iDepartmentService;

        public DepartmentsController() { }

        public DepartmentsController(IDepartmentService iDepartmentService)
        {
            _iDepartmentService = iDepartmentService;
        }

        // GET: api/Categories Get ALL
        public HttpResponseMessage GetDepartment()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in The Database");
            var get = _iDepartmentService.Get();
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
            var get = _iDepartmentService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        
        public HttpResponseMessage InsertDepartment(DepartmentVM DepartmentVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            var result = _iDepartmentService.Insert(DepartmentVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
    }
}