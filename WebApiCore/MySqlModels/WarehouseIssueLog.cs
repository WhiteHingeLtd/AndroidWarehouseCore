using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class WarehouseIssueLog
    {
        public int IssueId { get; set; }
        public string Sku { get; set; }
        public int? ReportingUser { get; set; }
        public string IssueType { get; set; }
        public string IssueReason { get; set; }
        public string DateReported { get; set; }
        public string OrderType { get; set; }
    }
}
