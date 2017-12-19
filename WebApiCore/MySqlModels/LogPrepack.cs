using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class LogPrepack
    {
        public int Logid { get; set; }
        public int? UserId { get; set; }
        public string UserFullName { get; set; }
        public string WorkstationName { get; set; }
        public string Time { get; set; }
        public string PpSku { get; set; }
        public string PpLabel { get; set; }
        public string PpQuantity { get; set; }
        public string PpShorttitle { get; set; }
        public string PpBinrack { get; set; }
        public string DateA { get; set; }

        public Employees User { get; set; }
    }
}
