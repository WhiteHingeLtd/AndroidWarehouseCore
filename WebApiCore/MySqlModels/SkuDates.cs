using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuDates
    {
        public string ShortSku { get; set; }
        public string FirstRecorded { get; set; }
        public string FirstPriced { get; set; }
        public string FirstPhoto { get; set; }
        public string AddedToLinnworks { get; set; }
        public string FirstListed { get; set; }
    }
}
