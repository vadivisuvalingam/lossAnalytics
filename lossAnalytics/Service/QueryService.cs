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
        private ObjectSql _objectSql;

        public QueryService(ObjectSql objectSql)
        {
            _objectSql = objectSql;
        }

        public string GetSelectStatement()
        {
            var retVal = new StringBuilder();
            retVal.Append("SELECT");
            retVal.Append(" ");
            foreach(var column in _objectSql.Columns())
            {

            }
            return retVal.ToString();
            
        }
    }
}