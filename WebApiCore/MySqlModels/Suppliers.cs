using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Suppliers
    {
        public int Suppid { get; set; }
        public string Suppname { get; set; }
        public string RealName { get; set; }
        public string Website { get; set; }
        public string WebSearchQuery { get; set; }
        public string Active { get; set; }
        public string SageSupp { get; set; }
    }
}
