using System;
using System.Collections.Generic;

namespace WebApiCore.MySqlModels
{
    public partial class MessengerMessages
    {
        public int Messageid { get; set; }
        public int? Participantid { get; set; }
        public string Messagecontent { get; set; }
        public string Timestamp { get; set; }
        public int? Threadid { get; set; }
    }
}
