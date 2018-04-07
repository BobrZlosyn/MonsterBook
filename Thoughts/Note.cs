using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Note : VersionalItem
    {
        private string text;

        public string Text {
            get
            {
                return text;
            }
            set
            {
                text = value;
                ControlSum = ComputeSum(text);
            }
        }
        public DateTime CreatedTime { get; set; }
        public DateTime ValidToDate { get; set; }
        public int Category { get; set; }

    }
}
