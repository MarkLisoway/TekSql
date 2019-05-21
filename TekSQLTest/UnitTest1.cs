using NUnit.Framework;
using TekSQL.Property.PostgreSql;

namespace TekSQLTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    public class MyClass
    {
        static void Test()
        {
          TqlPostgreSql.CreateProperty("test", )
        }
    }
}