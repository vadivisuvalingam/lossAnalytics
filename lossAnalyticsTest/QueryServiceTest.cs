using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lossAnalytics.Base;
using lossAnalytics.Service;

namespace lossAnalyticsTest
{
    [TestClass]
    public class QueryServiceTest
    {
        [TestMethod]
        public void TestSelect()
        {
            var ExpectedSelectStatement = "SELECT 'Column1','Column2','Column3' FROM 'Table'";
            var Column1 = new Moq.Mock<IColumn>();
            Column1.SetupProperty(x => x.ColumnName, "Column1");
            var Column2 = new Moq.Mock<IColumn>();
            Column2.SetupProperty(x => x.ColumnName, "Column2");
            var Column3 = new Moq.Mock<IColumn>();
            Column3.SetupProperty(x => x.ColumnName, "Column3");

            var ObjectSql = new Moq.Mock<IObjectSql>();
            ObjectSql.SetupProperty(x => x.Table, "Table");
            ObjectSql.SetupProperty(x => x.Columns, new List<IColumn>() { Column1.Object, Column2.Object, Column3.Object });

            var QueryService = new QueryService(ObjectSql.Object);
            var SelectString = QueryService.GetSelectStatement();
            Assert.AreEqual(ExpectedSelectStatement, SelectString);
        }

        [TestMethod]
        public void TestInsert()
        {
            var ExpectedSelectStatement = "INSERT INTO 'Table'( 'Column1','Column2','Column3') VALUES ('value1','value2','value3')";
            var Column1 = new Moq.Mock<IColumn>();
            Column1.SetupProperty(x => x.ColumnName, "Column1");
            var Column2 = new Moq.Mock<IColumn>();
            Column2.SetupProperty(x => x.ColumnName, "Column2");
            var Column3 = new Moq.Mock<IColumn>();
            Column3.SetupProperty(x => x.ColumnName, "Column3");

            var ObjectSql = new Moq.Mock<IObjectSql>();
            ObjectSql.SetupProperty(x => x.Table, "Table");
            ObjectSql.SetupProperty(x => x.Columns, new List<IColumn>() { Column1.Object, Column2.Object, Column3.Object });

            var QueryService = new QueryService(ObjectSql.Object);
            var InsertString = QueryService.GetInsertStatement(new List<string>() { "value1", "value2", "value3" });
            Assert.AreEqual(ExpectedSelectStatement, InsertString);
        }

        [TestMethod]
        public void TestDelete()
        {
            var ExpectedDeleteStatement = "DELETE * FROM 'Table'WHERE 'IdColumn' = '10'";
            var IdColumn = new Moq.Mock<IColumn>();
            IdColumn.SetupProperty(x => x.ColumnName, "IdColumn");

            var ObjectSql = new Moq.Mock<IObjectSql>();
            ObjectSql.SetupProperty(x => x.Table, "Table");
            ObjectSql.SetupProperty(x => x.Id, IdColumn.Object);

            var QueryService = new QueryService(ObjectSql.Object);
            var DeleteString = QueryService.GetDeleteStatement("10");
            Assert.AreEqual(ExpectedDeleteStatement, DeleteString);
        }

        [TestMethod]
        public void TestUpdate()
        {
            var ExpectedUpdateStatement = "UPDATE 'Table' SET 'Column1' = 'value1','Column2' = 'value2','Column3' = 'value3' WHERE 'IdColumn' = '23' ";
            var Column1 = new Moq.Mock<IColumn>();
            Column1.SetupProperty(x => x.ColumnName, "Column1");
            var Column2 = new Moq.Mock<IColumn>();
            Column2.SetupProperty(x => x.ColumnName, "Column2");
            var Column3 = new Moq.Mock<IColumn>();
            Column3.SetupProperty(x => x.ColumnName, "Column3");

            var IdColumn = new Moq.Mock<IColumn>();
            IdColumn.SetupProperty(x => x.ColumnName, "IdColumn");

            var ObjectSql = new Moq.Mock<IObjectSql>();
            ObjectSql.SetupProperty(x => x.Table, "Table");
            ObjectSql.SetupProperty(x => x.Id, IdColumn.Object);

            var QueryService = new QueryService(ObjectSql.Object);
            var UpdateString = QueryService.GetUpdateStatement(new Dictionary<IColumn, String> () { { Column1.Object, "value1" }, { Column2.Object, "value2" }, { Column3.Object, "value3" } }, "23");
            Assert.AreEqual(ExpectedUpdateStatement, UpdateString);
        }
    }
}
