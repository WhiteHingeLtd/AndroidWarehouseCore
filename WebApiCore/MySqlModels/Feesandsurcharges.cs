using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Feesandsurcharges
    {
        public int FeesId { get; set; }
        public string Desc { get; set; }
        public float? Value { get; set; }
    }
}
