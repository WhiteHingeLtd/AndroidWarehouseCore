using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WhiteHingeFramework.Classes;
using WhiteHingeFrameworkExt.Models;

namespace WebApiCore.Controllers.ApiControllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    public class DeviceManagementController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="employeeId"></param>
        /// <param name="appVersion"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Device/RecordLocation")]
        public ReturnObject<AndroidDevices> SendDeviceLocationInfo(string serialNumber,int employeeId,int appVersion)
        {
            using (var context = new WhiteHingeContext())
            {
                var returnable = context.AndroidDeviceLog.Single(x => x.Serials == serialNumber);
                returnable.LastSeen = DateTime.Now;
                returnable.LoggedInUser = employeeId;
                returnable.AppVersion = appVersion;
                context.SaveChanges();
                return new ReturnObject<AndroidDevices>(returnable);
            }
            
        }

    }
}