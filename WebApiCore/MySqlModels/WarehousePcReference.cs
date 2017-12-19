using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class WarehousePcReference
    {
        public int Pcid { get; set; }
        public int? WarehouseNumber { get; set; }
        public string MachineName { get; set; }
        public int? WarehouseId { get; set; }
    }
}
