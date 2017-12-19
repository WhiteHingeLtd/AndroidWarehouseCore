using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class NewsalesDailysourcetotals
    {
        public int TotalId { get; set; }
        public string SubsourceText { get; set; }
        public string TotalDate { get; set; }
        public string TotalDayOfWeek { get; set; }
        public int? TotalValue { get; set; }
        public string Tlsource { get; set; }
    }
}
