using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class StockHistory
    {
        public int StohistId { get; set; }
        public string ShortSku { get; set; }
        public int? StockLevel { get; set; }
        public int? StockMinimum { get; set; }
        public string StockDate { get; set; }
        public double PostageCost { get; set; }
        public double EnvelopeCost { get; set; }
        public double LabourCost { get; set; }
        public double NetPrice { get; set; }
    }
}
