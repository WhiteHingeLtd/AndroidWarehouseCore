using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class Employees
    {
        public Employees()
        {
            LogClockcard = new HashSet<LogClockcard>();
            LogLoginout = new HashSet<LogLoginout>();
            LogPrepack = new HashSet<LogPrepack>();
        }

        public int PayrollNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string WarehouseAreaStart { get; set; }
        public string WarehouseAreaFinish { get; set; }
        public string LoginPin { get; set; }
        public int? LoginTimeout { get; set; }
        public string NotShowOnTable { get; set; }
        public string AuthCodes { get; set; }
        public string ProtAuthCode { get; set; }
        public string HashedPin { get; set; }
        public string StartDate { get; set; }
        public string ActiveDirectoryUser { get; set; }

        public ICollection<LogClockcard> LogClockcard { get; set; }
        public ICollection<LogLoginout> LogLoginout { get; set; }
        public ICollection<LogPrepack> LogPrepack { get; set; }
    }
}
