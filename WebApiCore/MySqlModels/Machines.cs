using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Machines
    {
        public int IdMachines { get; set; }
        public string MachineName { get; set; }
        public string MachineType { get; set; }
        public string Ipaddress { get; set; }
        public string Site { get; set; }
    }
}
