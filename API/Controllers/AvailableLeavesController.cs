using BusinessLogic.Services;
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
    public class AvailableLeavesController : ApiController
    {
        readonly IAvailableLeaveService _iAvailableLeaveService;
        public AvailableLeavesController() { }
        public AvailableLeavesController(IAvailableLeaveService iAvailableLeaveService)
        {
            _iAvailableLeaveService = iAvailableLeaveService;
        }

        // GET: api/AvailableLeaves
        public HttpResponseMessage GetAvailableLeaves()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in the Database");
            var get = _iAvailableLeaveService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/AvailableLeaves/5
        public HttpResponseMessage GetCompany(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iAvailableLeaveService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/AvailableLeaves/5
        public HttpResponseMessage Update(int id, AvailableLeaveVM availableleaveVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iAvailableLeaveService.Update(id, availableleaveVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // PUT: api/AvailableLeave/5
        [HttpPut]
        public HttpResponseMessage UpdateAvailableLeave(int id, AvailableLeaveVM availableleaveVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iAvailableLeaveService.Update(id, availableleaveVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/AvailableLeave
        public HttpResponseMessage Insert(AvailableLeaveVM availableleaveVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong AvailableLeave");
            var result = _iAvailableLeaveService.Insert(availableleaveVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/AvailableLeave/5
        public HttpResponseMessage DeleteAvailableLeave(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iAvailableLeaveService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}
