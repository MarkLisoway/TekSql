using NUnit.Framework;
using TekSQL;

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
            TqlPostgre.Field
                .Name("test")
                .Type(TqlPostgre.FieldTypes.BigInt)
                .Create();
        }
    }
}