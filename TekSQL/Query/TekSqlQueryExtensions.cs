using TekSQL.Properties;

namespace TekSQL.Query
{
    public static class TekSqlQueryExtensions
    {
        public static SelectProperty As(this TekSqlPropertyBase property, string name)
        {
            return new SelectProperty(property, name);
        }
    }
}