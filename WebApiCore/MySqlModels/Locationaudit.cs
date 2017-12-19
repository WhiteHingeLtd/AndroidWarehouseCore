using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Locationaudit
    {
        public int AuditId { get; set; }
        public string ShortSku { get; set; }
        public string LocationId { get; set; }
        public DateTime DateOfEvent { get; set; }
        public int? Additional { get; set; }
        public int AuditUserId { get; set; }
        public int? AuditEvent { get; set; }
        public string LocationText { get; set; }
        public string FriendlyString { get; set; }
        public string EventSource { get; set; }
        public int TotalAtTime { get; set; }
    }
}
