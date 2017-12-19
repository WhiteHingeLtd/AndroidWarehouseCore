using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class PostagePrices
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public float Cost { get; set; }
        public int Class { get; set; }
    }
}
