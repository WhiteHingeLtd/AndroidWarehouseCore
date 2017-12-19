using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class LogClockcard
    {
        public int Logid { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserStatus { get; set; }
        public string UserReason { get; set; }
        public string UserTime { get; set; }
        public string UsedCard { get; set; }
        public string Unit { get; set; }

        public Employees User { get; set; }
    }
}
