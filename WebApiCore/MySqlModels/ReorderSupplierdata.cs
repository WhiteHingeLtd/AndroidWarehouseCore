using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class ReorderSupplierdata
    {
        public int IdreorderSupplierdata { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierFullName { get; set; }
        public double? MinimumOrder { get; set; }
        public int? LeadDays { get; set; }
        public sbyte? CartonDiscount { get; set; }
        public double? ReorderPercentage { get; set; }
        public DateTime? LastOrder { get; set; }
        public string LastOrderGuid { get; set; }
    }
}
