using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class UserNotifications
    {
        public int NotificationId { get; set; }
        public int? PayrollId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationBody { get; set; }
        public string NotificationStyle { get; set; }
        public string NotExpiryDateTime { get; set; }
        public string NotIsRead { get; set; }
        public string NotImgLink { get; set; }
        public int? UserFromId { get; set; }
    }
}
