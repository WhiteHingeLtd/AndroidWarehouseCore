using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Oversoldorders
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string CompletedState { get; set; }
        public string AwaitingStock { get; set; }
        public string OversoldSku { get; set; }
        public string DateOfOversold { get; set; }
        public string ExtraInfo { get; set; }
    }
}
