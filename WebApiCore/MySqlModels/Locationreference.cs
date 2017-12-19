using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Locationreference
    {
        public Locationreference()
        {
            SkuLocations = new HashSet<SkuLocations>();
        }

        public int LocId { get; set; }
        public string LocText { get; set; }
        public int LocWarehouse { get; set; }
        public int LocType { get; set; }
        public int RouteId { get; set; }
        public int? PickOrReplenish { get; set; }
        public string OwZone { get; set; }

        public Warehousereference LocWarehouseNavigation { get; set; }
        public ICollection<SkuLocations> SkuLocations { get; set; }
    }
}
