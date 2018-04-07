using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Query
{
    public class SimpleTable
    {
        public string TableName { get; set; }
        protected bool IsEmpty { get; set; }
        protected string Query { get; set; }

        public SimpleTable (string tableName)
        {
            TableName = tableName;
            IsEmpty = true;
        }
        public ColumnQuery Select()
        {
            return (ColumnQuery) new ColumnQuery(this).AddSqlPart("SELECT");
        }
        protected ColumnQuery DistinctSelect()
        {
            return (ColumnQuery)new ColumnQuery(this).AddSqlPart("SELECT DISTINCT");
        }
        public ColumnQuery Insert()
        {
            return (ColumnQuery)new ColumnQuery(this).AddSqlPart("INSERT INTO");
        }

        public ColumnQuery Update()
        {
            return (ColumnQuery)new ColumnQuery(this).AddSqlPart("UPDATE");
        }
        public ColumnQuery Delete()
        {
            return (ColumnQuery)new ColumnQuery(this).AddSqlPart("DELETE");
        }
    }
}
