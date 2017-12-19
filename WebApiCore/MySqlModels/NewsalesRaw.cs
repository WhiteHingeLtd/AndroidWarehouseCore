using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class NewsalesRaw
    {
        public int SaleId { get; set; }
        public string Sku { get; set; }
        public string OrderId { get; set; }
        public string Subsource { get; set; }
        public decimal? SalePrice { get; set; }
        public int? SaleQuantity { get; set; }
        public string IsMixedOrder { get; set; }
        public string ChannelTitle { get; set; }
        public string OrderDate { get; set; }
        public decimal? PostagePaid { get; set; }
        public string Tlsource { get; set; }
        public string CustomLabel { get; set; }
        public string OrderDateTime { get; set; }
    }
}
