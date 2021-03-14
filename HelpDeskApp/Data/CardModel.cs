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

        public string ShortMessage
        {
            get {
                if (Message.Length > 40)
                    return Message.Substring(0, 37) + "...";
                else
                    return Message + "...";
            }
        }
        public String SpecialistMessage { get; set; }
    }
}
