using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class MessengerThreads
    {
        public int IdmessengerThreads { get; set; }
        public string ThreadId { get; set; }
        public string Participantid { get; set; }
        public int? Notified { get; set; }
    }
}
