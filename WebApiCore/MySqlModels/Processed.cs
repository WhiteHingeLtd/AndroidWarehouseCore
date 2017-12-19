using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Processed
    {
        public string Orderid { get; set; }
        public string ReferenceNumber { get; set; }
        public string ExternalReference { get; set; }
        public string SecReference { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string CustCompany { get; set; }
        public string ShipCustName { get; set; }
        public string ShipCustAddr1 { get; set; }
        public string ShipCustAddr2 { get; set; }
        public string ShipCustAddr3 { get; set; }
        public string ShipCustTown { get; set; }
        public string ShipCustRegion { get; set; }
        public string ShipCustPostcode { get; set; }
        public string ShipCustCountry { get; set; }
        public string ShipCustCountryCode { get; set; }
        public string BillCustName { get; set; }
        public string BillCustCompany { get; set; }
        public string BillCustAddr1 { get; set; }
        public string BillCustAddr2 { get; set; }
        public string BillCustAddr3 { get; set; }
        public string BillCustTown { get; set; }
        public string BillCustRegion { get; set; }
        public string BillCustPostcode { get; set; }
        public string BillCustCountry { get; set; }
        public string BillCustPhone { get; set; }
        public string DateRecieved { get; set; }
        public string DateProcessed { get; set; }
        public float? ShipCost { get; set; }
        public float? OrderTax { get; set; }
        public float? OrderTotal { get; set; }
        public string Currency { get; set; }
        public string OrderPaidStat { get; set; }
        public string OrderStatus { get; set; }
        public string OrderSource { get; set; }
        public string OrderSubSrc { get; set; }
        public string DateDispatchby { get; set; }
        public string DateCreated { get; set; }
        public string ShipServiceName { get; set; }
        public string ShipServiceTag { get; set; }
        public string ShipServiceCode { get; set; }
        public string ShipServiceVendor { get; set; }
        public string ShipPackingGroup { get; set; }
        public string ShipTrackingNumber { get; set; }
        public string CustChannelBuyerName { get; set; }
        public string Marker { get; set; }
        public string OrderPaymentMethod { get; set; }
        public string OrderOnHold { get; set; }
        public string OrderFullfillmentLocation { get; set; }
        public string OrderSku { get; set; }
        public string OrderTitle { get; set; }
        public string OrderOrigTitle { get; set; }
        public string OrderChannelSku { get; set; }
        public string OrderItemNumber { get; set; }
        public string OrderQuantity { get; set; }
        public string OrderUnitCost { get; set; }
        public string OrderLineDiscount { get; set; }
        public string OrderTaxRate { get; set; }
        public string OrderLineTax { get; set; }
        public string OrderLineTotalNoTax { get; set; }
        public string OrderLineTotal { get; set; }
        public string OrderIsService { get; set; }
        public string CompParentSku { get; set; }
        public string CompParentOrderItemNo { get; set; }
        public string OrderNotes { get; set; }
        public string Orderkey { get; set; }
        public string Hasemailed { get; set; }
    }
}
