using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskApp.Data
{
    public class CardModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreationDay { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public AlarmLevel Alarm { get; set; }
        public State CurrentState { get; set; }
    }
}
