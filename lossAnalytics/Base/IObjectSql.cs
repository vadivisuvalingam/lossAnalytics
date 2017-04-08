using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lossAnalytics.Base
{
    public interface IObjectSql
    {
        string Table { get; set; }
        IEnumerable<IColumn> Columns { get; set; }
        IColumn Id { get; set; }
    }
}
