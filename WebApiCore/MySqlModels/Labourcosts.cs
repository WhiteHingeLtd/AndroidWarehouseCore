using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Labourcosts
    {
        public int Code { get; set; }
        public float? Cost { get; set; }
        public string Desc { get; set; }
    }
}
