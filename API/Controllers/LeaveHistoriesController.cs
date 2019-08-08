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
    public class LeaveHistoriesController:ApiController
    {
        readonly ILeaveHistoryService _iLeaveHistoryService;
        public LeaveHistoriesController() { }
        public LeaveHistoriesController(ILeaveHistoryService iLeaveHistoryService)
        {
            _iLeaveHistoryService = iLeaveHistoryService;
        }
        //get api leavehistory
        public HttpResponseMessage GetLeaveHistory()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found In Database");
            var get = _iLeaveHistoryService.Get();
            if (get!=null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage GetLeaveHistory(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iLeaveHistoryService.Get(id);
            if (get!=null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        [HttpPut]
        public HttpResponseMessage UpdateLeaveHistory(int id, LeaveHistoryVM leaveHistoryVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iLeaveHistoryService.Update(id, leaveHistoryVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }
        public HttpResponseMessage InsertLeaveHistory(LeaveHistoryVM leaveHistoryVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iLeaveHistoryService.Insert(leaveHistoryVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteLeaveHistory(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iLeaveHistoryService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}