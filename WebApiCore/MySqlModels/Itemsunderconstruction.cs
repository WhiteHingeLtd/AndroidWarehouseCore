using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Itemsunderconstruction
    {
        public int ItemTempId { get; set; }
        public int? Batch { get; set; }
        public string EntryUser { get; set; }
        public string EntryDate { get; set; }
        public string Box { get; set; }
        public string Code { get; set; }
        public float? NetPrice { get; set; }
        public string OuterBarcode { get; set; }
        public string InnerBarcode { get; set; }
        public string ItemBarcode { get; set; }
        public string Brand { get; set; }
        public string Finish { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }
        public string Pc { get; set; }
        public string Parts { get; set; }
        public string Screws { get; set; }
        public string Distinguish { get; set; }
        public string Pair { get; set; }
        public string ShelfLocation { get; set; }
        public string StockLevel { get; set; }
        public string CheckedBy { get; set; }
        public string Exported { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string InnerCarton { get; set; }
        public string Oversized { get; set; }
        public string Notes { get; set; }
    }
}
