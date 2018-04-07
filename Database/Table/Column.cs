using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Column
    {
        public bool IsID { get; set; } = false;
        public string Name { get; set; }
        public SqlDbType Type { get; set; }
        
        public object Value { get; set; }
    }
}
