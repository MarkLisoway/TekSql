namespace TekSQL.Table
{
    public abstract class TekSqlTableBase : ITekSqlTable
    {
        protected TekSqlTableBase(string tableName)
        {
            TableName = tableName;
        }

        public string TableName { get; }
    }
}