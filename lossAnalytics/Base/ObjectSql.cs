using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lossAnalytics.Base
{
    public class ObjectSql : IObjectSql
    {
        private string _table;
        private IColumn _idColumn;
        private IEnumerable<IColumn> _columns;

        public ObjectSql()
        {

        }

        public string Table
        {
            get { return _table; }
            set { _table = value; }
        }

        public IEnumerable<IColumn> Columns
        {
            get { return _columns; }
            set { _columns = value; }
        }

        public IColumn Id
        {
            get { return _idColumn; }
            set { _idColumn = value; }
        }
    }
}