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
    public class HolidaysController : ApiController
    {
        readonly IHolidayService _iHolidayService;
        public HolidaysController() { }
        public HolidaysController(IHolidayService iHolidayService)
        {
            _iHolidayService = iHolidayService;
        }
        //get api holiday
        public HttpResponseMessage GetHoliday()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found In Database");
            var get = _iHolidayService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage GetHoliday(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iHolidayService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        [HttpPut]
        public HttpResponseMessage UpdateHoliday(int id, HolidayVM holidayVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iHolidayService.Update(id, holidayVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }
        public HttpResponseMessage InsertHoliday(HolidayVM holidayVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iHolidayService.Insert(holidayVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
        public HttpResponseMessage DeleteHoliday(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iHolidayService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}