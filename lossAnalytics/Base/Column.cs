using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lossAnalytics.Base
{
    public class Column
    {
        private string _columnName;

        public Column()
        {

        }

        public string ColumnName
        {
            get
            {
                return _columnName;
            }
            set
            {
                _columnName = value;
            }
        }
    }
}