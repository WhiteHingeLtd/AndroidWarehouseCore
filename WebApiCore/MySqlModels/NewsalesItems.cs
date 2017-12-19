using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class NewsalesItems
    {
        public int Itemfinancial { get; set; }
        public string Sku { get; set; }
        public int? Quantity { get; set; }
        public double? Net { get; set; }
        public double? NetProportion { get; set; }
        public double? Labour { get; set; }
        public double? ItemProfit { get; set; }
        public string OrderId { get; set; }
        public string PickType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
