using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Inventory
    {
        public string Sku { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public double? Retail { get; set; }
        public double? Cost { get; set; }
        public string Pack { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Depth { get; set; }
        public string Taxrate { get; set; }
        public string Defaultpost { get; set; }
        public string Defaultpacking { get; set; }
        public string Variant { get; set; }
        public string Archived { get; set; }
        public string Barcode { get; set; }
        public string Location { get; set; }
        public string Stockavailable { get; set; }
        public string Stockorder { get; set; }
        public string Stock { get; set; }
        public string Stockvalue { get; set; }
        public string Stockminimum { get; set; }
        public string Stockdue { get; set; }
    }
}
