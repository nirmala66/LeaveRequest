﻿using BusinessLogic.Services.Interfaces;
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
    public class ProvincesController :ApiController
    {
        readonly IProvinceService _iProvinceService;
        public ProvincesController() { }
        public ProvincesController(IProvinceService iProvinceService)
        {
            _iProvinceService = iProvinceService;
        }
        //get api Province
        public HttpResponseMessage GetProvince()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found In Database");
            var get = _iProvinceService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        public HttpResponseMessage GetProvince(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iProvinceService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        //public HttpResponseMessage UpdateProvince(int id, ProvinceVM provinceVM)
        //{
        //    var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
        //    if (string.IsNullOrWhiteSpace(id.ToString()))
        //    {
        //        message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
        //    }
        //    else
        //    {
        //        var get = _iProvinceService.Update(id, provinceVM);
        //        if (get)
        //        {
        //            message = Request.CreateResponse(HttpStatusCode.OK, get);
        //            return message;
        //        }
        //    }
        //    return message;
        //}
        public HttpResponseMessage InsertProvince(ProvinceVM provinceVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iProvinceService.Insert(provinceVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Succesfully Added");
            }
            return message;
        }
        //public HttpResponseMessage DeleteProvince(int id)
        //{
        //    var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
        //    if (string.IsNullOrWhiteSpace(id.ToString()))
        //    {
        //        message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
        //    }
        //    else
        //    {
        //        var result = _iProvinceService.Delete(id);
        //        if (result)
        //        {
        //            message = Request.CreateResponse(HttpStatusCode.OK);
        //        }
        //    }
        //    return message;
        //}
    }
}