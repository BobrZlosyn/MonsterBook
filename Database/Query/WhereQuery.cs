using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Query
{
    public class WhereQuery : QueryLine
    {
        private int valCount;

        public WhereQuery (SimpleTable table) : base(table)
        {
            valCount = 0;
            IsEmpty = true;
        }

        public FinalizationQuery Empty ()
        {
            return new FinalizationQuery();
        }
        
        public WhereQuery AddEqualClause(Column col)
        {
            AddValue(col, "=");
            return this;
        }
        public WhereQuery AddNotEqualClause(Column col)
        {
            AddValue(col, "<>");
            return this;
        }
        public WhereQuery AddGreaterClause(Column col)
        {
            AddValue(col, ">");
            return this;
        }
        public WhereQuery AddLessClause(Column col)
        {
            AddValue(col, "<");
            return this;
        }
        public WhereQuery AddLessEqualClause(Column col)
        {
            AddValue(col, "<=");
            return this;
        }
        public WhereQuery AddGreaterEqualClause(Column col)
        {
            AddValue(col, "<=");
            return this;
        }
        public WhereQuery AddAnd()
        {
            if (!IsEmpty)
            {
                AddSqlPart("AND");
            }
            return this;
        }
        public WhereQuery AddOr()
        {
            if (!IsEmpty)
            {
                AddSqlPart("OR");
            }
            return this;
        }
        public FinalizationQuery AddEqualClauses (IList <Column> cols, bool useAnd)
        {
            foreach (Column col in cols)
            {
                AddEqualClause(col);
                if (useAnd)
                {
                    AddAnd();
                }
                else
                {
                    AddOr();
                }
                
            }
            return new FinalizationQuery();
        }
        public FinalizationQuery AddNotEqualClauses(IList<Column> cols, bool useAnd)
        {
            foreach (Column col in cols)
            {
                AddNotEqualClause(col);
                if (useAnd)
                {
                    AddAnd();
                }
                else
                {
                    AddOr();
                }

            }
            return new FinalizationQuery();
        }

        private void AddValue(Column col, string action)
        {
            IsEmpty = false;
            string name = "@value" + valCount;
            valCount++;
            AddSqlPart(col.Name);
            AddSqlPart(action);
            AddSqlPart(name);
            AddSqlValue(name, col.Value, col.Type);
        }
    }
}
