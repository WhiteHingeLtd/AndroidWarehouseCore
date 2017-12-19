using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class ReorderOrders
    {
        public int ReorderOrdersId { get; set; }
        public string OrderGuid { get; set; }
        public string SupplierCode { get; set; }
        public string CustomOrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderDelivered { get; set; }
        public DateTime? OrderInvoiced { get; set; }
        public int? LinesOfStock { get; set; }
        public decimal? NetValue { get; set; }
        public string CustomOrderNote { get; set; }
        public string CustomDeliveryNote { get; set; }
        public int OrderState { get; set; }
    }
}
