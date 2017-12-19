using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class LocationRouting
    {
        public int RouteId { get; set; }
        public int? RouteIndex { get; set; }
        public string RouteBlockName { get; set; }
        public int? WarehouseId { get; set; }
        public int? ZoneId { get; set; }
    }
}
