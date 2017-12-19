using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class VncClients
    {
        public int ClientId { get; set; }
        public string ClientHostname { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
