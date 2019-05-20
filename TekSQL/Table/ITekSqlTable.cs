using TekSQL.Entity;

namespace TekSQL.Table
{
    public interface ITekSqlTable
    {
        ITekSqlEntity Entity { get; }
    }
}