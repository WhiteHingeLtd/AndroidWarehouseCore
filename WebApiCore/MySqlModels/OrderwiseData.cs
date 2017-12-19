using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class OrderwiseData
    {
        public string Sku { get; set; }
        public string NumberOfBaseUnits { get; set; }
        public string EstimatedCost { get; set; }
        public string EanCode { get; set; }
        public string MainCategory { get; set; }
        public string StockLocation { get; set; }
        public string DefaultStockBinNumber { get; set; }
        public string AlternativeVariantCode { get; set; }
        public string Barcode { get; set; }
        public string OwPrepacknote { get; set; }
        public string OwPacknote { get; set; }
        public string OwDeliverynote { get; set; }
        public string OwPicknote { get; set; }
        public string AmazonId { get; set; }
        public string Guideprice { get; set; }
        public string Ourean { get; set; }
        public string ItemTitle { get; set; }
        public string OwPackof { get; set; }
        public string ItemtitlePackof { get; set; }
        public string CategoryPath { get; set; }
        public string OwIsPrepack { get; set; }
        public string OwTraining { get; set; }
        public string OwEnvelope { get; set; }
        public string OwItemexpires { get; set; }
        public string OwPostaltype { get; set; }
        public string OwPackingtype { get; set; }
        public string OwPackdescription { get; set; }
        public float? OwWeight { get; set; }
        public string OwReqexpiry { get; set; }
        public string OwPurchaseVariant { get; set; }
        public string OwIsprepackfinalfinal { get; set; }
        public bool? Sys2IsPrepack { get; set; }
    }
}
