using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Envelopes
    {
        public string EnvCode { get; set; }
        public string EnvName { get; set; }
        public int? EnvWeight { get; set; }
        public string EnvSize { get; set; }
        public string EnvFrom { get; set; }
        public int? EnvBoxQuan { get; set; }
        public float? EnvBoxNet { get; set; }
        public float? EnvIndCost { get; set; }
        public string NeedsBox { get; set; }
        public string IsHidden { get; set; }
        public string EnvNewName { get; set; }
    }
}
