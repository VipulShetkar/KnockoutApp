using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using KnockoutApi.Models;
namespace KnockoutApi.Controllers
{
    public class BaseController : ApiController
    {
        public ResponseModel ResponseData(bool isSuccess, dynamic data)
        {
            var objResponseModel = new ResponseModel() { IsSuccess = isSuccess };
            try
            {
                objResponseModel.ResponseData = data;
            }
            catch (Exception ex)
            {
                objResponseModel.IsSuccess = false;
                objResponseModel.ResponseData = ex.Message;

            }
            return objResponseModel;
        }
    }
}