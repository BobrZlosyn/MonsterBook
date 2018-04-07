using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Database.Query;

namespace Database
{
    public class Program
    {
        public void Test ()
        {
            SimpleTable table = new SimpleTable("something");
            //table.Select().AllColumns().AddEqualClauses();
            
            HttpClient client = new HttpClient();

        }
    }
}
