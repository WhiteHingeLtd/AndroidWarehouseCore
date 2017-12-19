using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class ShortskuLocations
    {
        public string Id { get; set; }
        public string Shortsku { get; set; }
        public int LocationId { get; set; }
        public string Shelfname { get; set; }
        public double? StockLevel { get; set; }
    }
}
