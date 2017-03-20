using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}