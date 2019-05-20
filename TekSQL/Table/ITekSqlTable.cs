using TekSQL.Expression;

namespace TekSQL.Table
{
    /// <summary>
    /// Represents a table in the database as well as
    /// any configurations on the table itself.
    /// </summary>
    public interface ITekSqlTable : ITekSqlExpression
    {
        string TableName { get; }
    }
}