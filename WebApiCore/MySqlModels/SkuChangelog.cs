using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuChangelog
    {
        public int Logid { get; set; }
        public string Shortsku { get; set; }
        public string PayrollId { get; set; }
        public string Reason { get; set; }
        public string Datetimechanged { get; set; }
    }
}
