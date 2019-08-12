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
    public class DivisionsController : ApiController
    {
        readonly IDivisionService _iDivisionService;

        public DivisionsController() { }

        public DivisionsController(IDivisionService iDivisionService)
        {
            _iDivisionService = iDivisionService;
        }

        // GET: api/Categories Get ALL
        public HttpResponseMessage GetDivision()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in The Database");
            var get = _iDivisionService.Get();
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
            var get = _iDivisionService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage InsertDivision(DivisionVM DivisionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iDivisionService.Insert(DivisionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
    }
}