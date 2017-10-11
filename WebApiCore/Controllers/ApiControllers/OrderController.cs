using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using WhiteHingeFrameworkExt.Models;

namespace WebApiCore.Controllers.ApiControllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    public class OrderController : Controller
    {
        /// <summary>
        /// Test App
        /// </summary>
        /// <returns>A list of all device data</returns>
        [HttpPost]
        [Route("Test/Logs")]
        public List<AndroidDevices> GetAllLog()
        {
            var returnable = new List<AndroidDevices>();
            using (var context = new WhiteHingeContext())
            {
                returnable.AddRange(context.AndroidDeviceLog);
            }
            return returnable;
        }
        [HttpGet]
        [Route("Test/Throw")]
        public HttpResponseMessage ThrowError()
        {
            throw new NullReferenceException();
        }
        [HttpGet]
        [Route("Test/500")]
        public HttpResponseMessage Return500()
        {
            return new HttpResponseMessage(HttpStatusCode.Gone);
        }
    }
}