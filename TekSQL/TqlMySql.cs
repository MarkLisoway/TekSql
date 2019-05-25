using TekSQL.FieldBuilder.MySql;
using TekSQL.FieldType.MySql;

namespace TekSQL
{
    public static class TqlMySql
    {
        public static MySqlFieldBuilder Field => new MySqlFieldBuilder();
        
        public static readonly MySqlFieldTypes FieldTypes = new MySqlFieldTypes();
    }
}