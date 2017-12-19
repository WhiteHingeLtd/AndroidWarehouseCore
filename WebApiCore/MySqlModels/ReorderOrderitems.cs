using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class ReorderOrderitems
    {
        public int IdreorderOrderitems { get; set; }
        public string Shortsku { get; set; }
        public string OrderGuid { get; set; }
        public int? AmountOrdered { get; set; }
        public decimal? NetPrice { get; set; }
    }
}
