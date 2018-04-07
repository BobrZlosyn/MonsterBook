using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Query
{
    public class QueryLine
    {
        public List <SqlParameter> Parameters { get; }
        protected SimpleTable Table { get; set; }
        protected bool IsEmpty { get; set; }
        protected string Query { get; set; }

        public QueryLine(SimpleTable table)
        {
            IsEmpty = true;
            Table = table;
            Query = string.Empty;
        }
        public QueryLine AddSqlPart (string sqlPart)
        {
            Query += sqlPart + " ";
            return this;
        }

        public void Clear ()
        {
            Query = string.Empty;
        }

        public void AddSqlValue(string columnDesc, object value, SqlDbType type)
        {
            SqlParameter parameter = new SqlParameter(columnDesc, value);
            parameter.SqlDbType = type;
            Parameters.Add(parameter);
        }
    }
}
