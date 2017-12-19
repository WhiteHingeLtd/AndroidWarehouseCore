using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class SkuComposition
    {
        public int CompositionId { get; set; }
        public string BundleSku { get; set; }
        public string ChildSku { get; set; }
    }
}
