using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Warehousereference
    {
        public Warehousereference()
        {
            Locationreference = new HashSet<Locationreference>();
        }

        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseReferencecol { get; set; }

        public ICollection<Locationreference> Locationreference { get; set; }
    }
}
