using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using lossAnalytics.Base;

namespace lossAnalytics.Service
{
    public class QueryService
    {
        private IObjectSql _objectSql;

        public QueryService(IObjectSql objectSql)
        {
            _objectSql = objectSql;
        }

        public string GetSelectStatement()
        {
            var retVal = new StringBuilder();
            retVal.Append("SELECT");
            retVal.Append(" ");
            foreach(var column in _objectSql.Columns.Select((value, i) => new { i, value }))
            {
                retVal.Append($"'{column.value.ColumnName}' ");
                if(column.i < (_objectSql.Columns.Count() - 1)) { 
                    retVal.Append(", ");
                }
            }
            retVal.Append($"FROM '{ _objectSql.Table }'");

            return retVal.ToString();
            
        }

        public string GetInsertStatement(List<string> values)
        {
            var retVal = new StringBuilder();
            retVal.Append($"INSERT INTO '{_objectSql.Table}'");
            retVal.Append("( ");
            foreach (var column in _objectSql.Columns.Select((value, i) => new { i, value }))
            {
                retVal.Append($"'{column.value.ColumnName}' ");
                if (column.i < (_objectSql.Columns.Count() - 1))
                {
                    retVal.Append(", ");
                }
            }
            retVal.Append(")");

            return retVal.ToString();
        }

        public string GetDeleteStatement(string id)
        {
            var retVal = new StringBuilder();
            retVal.Append($"DELETE * FROM '{_objectSql.Table}'");
            retVal.Append($"WHERE '{_objectSql.Id.ColumnName}' = '{id}'");

            return retVal.ToString();
        }

        public string GetUpdateStatement(Dictionary<Column, String> columnValuePairs, string id)
        {
            return string.Empty;
        }
    }
}