using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class TodoItem : VersionalItem
    {
        private string message;

        public int ID { get; set; }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                ControlSum = ComputeSum(value);
            }
        }
        public string Title { get; set; }
        public int Category { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinnishTime { get; set; }

    }
}
