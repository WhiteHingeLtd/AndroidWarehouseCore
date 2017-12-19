using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class PrepackCleared
    {
        public int Orderid { get; set; }
        public DateTime? Time { get; set; }
        public string Sku { get; set; }
        public string UserCleared { get; set; }
    }
}
