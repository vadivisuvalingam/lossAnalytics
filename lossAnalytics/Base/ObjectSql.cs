using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lossAnalytics.Base
{
    public class ObjectSql
    {
        private string _table;
        private Column _idColumn;

        public ObjectSql()
        {

        }

        public string Table
        {
            get { return _table; }
            set { _table = value; }
        }

        public List<Column> Columns()
        {
            var retValue = new List<Column>();
            return retValue;
        }

        public Column Id
        {
            get { return _idColumn; }
            set { _idColumn = value; }
        }
    }
}