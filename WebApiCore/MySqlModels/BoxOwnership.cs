using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class BoxOwnership
    {
        public int Id { get; set; }
        public string BoxNumber { get; set; }
        public int UserId { get; set; }
    }
}
