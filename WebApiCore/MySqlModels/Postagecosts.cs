using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Postagecosts
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? Weight { get; set; }
        public string Cost { get; set; }
    }
}
