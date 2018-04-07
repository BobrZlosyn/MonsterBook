using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class CalendarEvent : VersionalItem
    {
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string EventName { get; set; }
        public string EventNotes { get; set; }
        public bool IsRepeating { get; set; }
        public int EventType { get; set; }
        public int RepeatingType { get; set; }
        public int Importance { get; set; }
        public int EventID { get; set; }

    }
}
