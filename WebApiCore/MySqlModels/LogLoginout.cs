using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class LogLoginout
    {
        public int Logid { get; set; }
        public int? UserId { get; set; }
        public string UserFullName { get; set; }
        public string WorkstationName { get; set; }
        public string Action { get; set; }
        public string Time { get; set; }

        public Employees User { get; set; }
    }
}
