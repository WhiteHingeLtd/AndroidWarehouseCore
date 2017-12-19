using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Salesdata
    {
        public string Sku { get; set; }
        public int? Raw8WeekTotal { get; set; }
        public int? Raw4WeekTotal { get; set; }
        public int? Raw1WeekTotal { get; set; }
        public int? Weighted8Week { get; set; }
        public int? Avg8Week { get; set; }
        public int? Avg4Week { get; set; }
        public int? Avg1Week { get; set; }
        public string ShortSku { get; set; }
    }
}
