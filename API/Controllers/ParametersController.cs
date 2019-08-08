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
    public class ParametersController : ApiController
    {
        readonly IParameterService _iParameterService;
        public ParametersController() { }
        public ParametersController(IParameterService iParameterService)
        {
            _iParameterService = iParameterService;
        }

        // GET: api/Parameters
        public HttpResponseMessage GetParameters()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iParameterService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Parameters/5
        public HttpResponseMessage GetCompany(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iParameterService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Parameters/5
        public HttpResponseMessage Update(int id, ParameterVM parameterVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iParameterService.Update(id, parameterVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // PUT: api/Parameters/5
        [HttpPut]
        public HttpResponseMessage UpdateParameter(int id, ParameterVM parameterVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iParameterService.Update(id, parameterVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Parameters
        public HttpResponseMessage Insert(ParameterVM parameterVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iParameterService.Insert(parameterVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Parameters/5
        public HttpResponseMessage DeleteParameter(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iParameterService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}
