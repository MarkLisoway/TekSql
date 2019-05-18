using TekSQL.Properties;

namespace TekSQL.Query
{
    public sealed class SelectProperty
    {
        private readonly TekSqlPropertyBase _property;
        private readonly string _queryName;
        
        internal SelectProperty(TekSqlPropertyBase property, string queryName)
        {
            _property = property;
            _queryName = queryName;
        }
    }
}