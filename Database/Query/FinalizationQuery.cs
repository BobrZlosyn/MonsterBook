using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Query
{
    public class FinalizationQuery
    {
        public FinalizationQuery GroupBy(bool useAscendic = true)
        {
            return this;
        }

        public FinalizationQuery Limit()
        {
            return this;
        }
        
    }
}
