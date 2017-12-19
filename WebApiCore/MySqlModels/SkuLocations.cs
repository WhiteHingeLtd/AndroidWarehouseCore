using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuLocations
    {
        public string Id { get; set; }
        public string ShelfName { get; set; }
        public string Sku { get; set; }
        public int AdditionalInfo { get; set; }
        public int LocationRefId { get; set; }

        public Locationreference LocationRef { get; set; }
    }
}
