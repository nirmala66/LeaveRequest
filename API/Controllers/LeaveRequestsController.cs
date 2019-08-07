using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class LeaveRequestsController :ApiController
    {
        readonly ILeaveRequestService _iLeaveRequestService;
        public LeaveRequestsController() { }
        public LeaveRequestsController(ILeaveRequestService iLeaveRequestService)
        {
            _iLeaveRequestService = iLeaveRequestService;
        }
        //get api leaverequest
        public HttpResponseMessage GetLeaveRequest()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found In Database");
            var get = _iLeaveRequestService.Get();
            if (get!=null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage GetLeaveRequest(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iLeaveRequestService.Get(id);
            if (get!=null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        public HttpResponseMessage UpdateLeaveRequest(int id, LeaveRequestVM leaveRequestVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iLeaveRequestService.Update(id, leaveRequestVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }
        public HttpResponseMessage InsertLeaveRequest(LeaveRequestVM leaveRequestVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iLeaveRequestService.Insert(leaveRequestVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteLeaveRequest(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iLeaveRequestService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}