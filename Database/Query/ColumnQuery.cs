using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database.Query
{
    public class ColumnQuery : QueryLine
    {
        private List<Column> columns;
        public ColumnQuery (SimpleTable table) : base (table)
        {
            columns = new List<Column>();
        }

        public void AddColumn(Column col)
        {
            columns.Add(col);
        }

        public void AddColumns(IList <Column> cols)
        {
            columns.AddRange(cols);
        }

        public WhereQuery Min(Column col)
        {
            return AddFunction("MIN", col);
        }
        public WhereQuery Max(Column col)
        {
            return AddFunction("MAX", col);
        }
        public WhereQuery Count(Column col)
        {
            return AddFunction("COUNT", col);
        }
        public WhereQuery Sum(Column col)
        {
            return AddFunction("SUM", col);

        }
        public WhereQuery Avg(Column col)
        {
            return AddFunction("AVG", col);
        }
        public WhereQuery AllColumns()
        {
            WhereQuery where = new WhereQuery(base.Table);
            where.AddSqlPart("*");
            AddFromTable();
            return where;
        }
        private WhereQuery AddFunction(string functionName, Column col)
        {
            WhereQuery where = new WhereQuery(base.Table);
            where.AddSqlPart(functionName + " (");
            where.AddSqlPart(col.Name);
            where.AddSqlPart(")");
            AddFromTable();
            return where;
        }
        private void AddFromTable ()
        {
            AddSqlPart("FROM");
            AddSqlPart(Table.TableName);
        }
    }
}
