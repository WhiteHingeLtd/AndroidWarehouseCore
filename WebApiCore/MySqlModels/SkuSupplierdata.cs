using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuSupplierdata
    {
        public string SkuSuppKey { get; set; }
        public string Sku { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierBarcode { get; set; }
        public string SupplierCaseBarcode { get; set; }
        public string SupplierCaseQuantity { get; set; }
        public string SupplierPricePer { get; set; }
        public string IsPrimary { get; set; }
        public string IsDiscontinued { get; set; }
        public string IsOutOfStock { get; set; }
        public string DateModified { get; set; }
        public string LeadTimeWeeks { get; set; }
        public string SupplierCaseInnerBarcode { get; set; }
        public string SupplierBoxCode { get; set; }
        public string Invisible { get; set; }
        public int LeadTimeNew { get; set; }
    }
}
