using System;
using NUnit.Framework;
using TekSQL;
using TekSQL.Field;
using TekSQL.FieldType;

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
            MyClass.Test();
            Assert.Pass();
        }
    }

    public class MyClass
    {
        public static void Test()
        {
            var TestField = TqlMySql.Field
                .Name("TestField")
                .Type(TqlMySql.FieldTypes.Char(16))
                .Create();
        }
    }
}