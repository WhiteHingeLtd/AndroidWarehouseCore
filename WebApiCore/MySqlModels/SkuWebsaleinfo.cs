using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuWebsaleinfo
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string ListingTitle { get; set; }
        public string ListingDescription { get; set; }
        public int? CreatedUser { get; set; }
        public string ItemId { get; set; }
        public string Website { get; set; }
    }
}
