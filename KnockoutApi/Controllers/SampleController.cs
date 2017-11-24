using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.IO;
using KnockoutApi.Models;
using System.Web.Http.Cors;
namespace KnockoutApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Home")]
    public class SampleController : BaseController
    {
        // GET: Sample
        public ResponseModel SampleData([FromBody] RequestModel objRequestModel)
        {
            try
            {
                SampleModel betinfo = (SampleModel)JsonConvert.DeserializeObject(objRequestModel.JsonData, typeof(SampleModel));

                return ResponseData(true, "Success");
            }
            catch (Exception ex)
            {
                return ResponseData(false, ex);
            }
        }
    }
}