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
            retVal.Append(string.Join(",", _objectSql.Columns.Select(x => $"'{x.ColumnName}'").ToArray()));
            retVal.Append(" ");
            retVal.Append($"FROM '{ _objectSql.Table }'");

            return retVal.ToString();
            
        }

        public string GetInsertStatement(IEnumerable<string> values)
        {
            var retVal = new StringBuilder();
            retVal.Append($"INSERT INTO '{_objectSql.Table}'");
            retVal.Append("( ");
            retVal.Append(string.Join(",", _objectSql.Columns.Select( x => $"'{x.ColumnName}'").ToArray()));
            retVal.Append(") ");
            retVal.Append("VALUES (");
            retVal.Append(string.Join(",", values.Select(x => $"'{x}'").ToArray()));
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

        public string GetUpdateStatement(IDictionary<IColumn, String> columnValuePairs, string id)
        {
            var retVal = new StringBuilder();
            retVal.Append($"UPDATE '{_objectSql.Table}' SET ");
            retVal.Append(string.Join(",", columnValuePairs.Select(x => $"'{x.Key.ColumnName}' = '{x.Value}'").ToArray()));
            retVal.Append(" WHERE ");
            retVal.Append($"'{_objectSql.Id.ColumnName}' = '{id}' ");
            return retVal.ToString();
        }
    }
}