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
    public class RegenciesController : ApiController
    {
        readonly IRegencyService _iRegencyService;
        public RegenciesController() { }
        public RegenciesController(IRegencyService iRegencyService)
        {
            _iRegencyService = iRegencyService;
        }

        // GET: api/Regencys
        public HttpResponseMessage GetRegencys()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iRegencyService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Regencys/5
        public HttpResponseMessage GetCompany(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iRegencyService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // POST: api/Religions
        public HttpResponseMessage Insert(RegencyVM RegencyVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Regency");
            var result = _iRegencyService.Insert(RegencyVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }
    }
}
