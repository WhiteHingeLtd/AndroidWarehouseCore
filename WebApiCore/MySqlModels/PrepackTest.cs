using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class PrepackTest
    {
        public int Orderid { get; set; }
        public int? Iscomplete { get; set; }
        public string Pplocationid { get; set; }
        public string Pplocationname { get; set; }
        public string DateCleared { get; set; }
    }
}
