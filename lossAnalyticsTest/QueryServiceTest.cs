using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lossAnalytics.Base;
using lossAnalytics.Service;

namespace lossAnalyticsTest
{
    [TestClass]
    public class QueryServiceTest
    {
        [TestMethod]
        public void TestDelete()
        {
            var expectedDeleteStatement = "DELETE * FROM 'Table'WHERE 'IdColumn' = '10'";
            var IdColumn = new Moq.Mock<IColumn>();
            IdColumn.SetupProperty(x => x.ColumnName, "IdColumn");

            var ObjectSql = new Moq.Mock<IObjectSql>();
            ObjectSql.SetupProperty(x => x.Table, "Table");
            ObjectSql.SetupProperty(x => x.Id, IdColumn.Object);

            var QueryService = new QueryService(ObjectSql.Object);
            var DeleteString = QueryService.GetDeleteStatement("10");
            Assert.AreEqual(expectedDeleteStatement, DeleteString);
        }
    }
}
