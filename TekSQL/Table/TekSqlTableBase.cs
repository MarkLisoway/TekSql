using TekSQL.Expression;

namespace TekSQL.Table
{
    public abstract class TekSqlTableBase : TekSqlExpressionBase, ITekSqlTable
    {
        protected TekSqlTableBase(string tableName) : base(tableName)
        {
            TableName = tableName;
        }

        public string TableName { get; }

        public abstract override string ToPartialQueryString();
    }
}