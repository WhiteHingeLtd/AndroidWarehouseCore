using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class NewsalesFinancials
    {
        public int FinancialId { get; set; }
        public string OrderId { get; set; }
        public double? Retail { get; set; }
        public double PostagePaid { get; set; }
        public string CombinedPost { get; set; }
        public double? Tax { get; set; }
        public double? SubTotal { get; set; }
        public double? CostFees { get; set; }
        public double? CostNet { get; set; }
        public double? CostLabour { get; set; }
        public double? CostPostage { get; set; }
        public double? CostEnvelope { get; set; }
        public double? CostLabel { get; set; }
        public double? CostSurcharge { get; set; }
        public double? TotalProfit { get; set; }
        public string PostageType { get; set; }
        public string PickType { get; set; }
        public string Source { get; set; }
        public string SubSource { get; set; }
        public int? PostClass { get; set; }
        public string PostageTypeDecision { get; set; }
        public int? OrderWeight { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
