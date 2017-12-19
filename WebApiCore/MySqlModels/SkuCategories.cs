using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuCategories
    {
        public int CatId { get; set; }
        public string CategoryName { get; set; }
        public string AmazonNode { get; set; }
    }
}
