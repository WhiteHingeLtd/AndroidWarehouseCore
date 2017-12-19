using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuImages
    {
        public string Filename { get; set; }
        public string Path { get; set; }
        public string Sku { get; set; }
        public string Shortsku { get; set; }
        public string IsPrimary { get; set; }
    }
}
