using TekSQL.FieldType.MySql;

namespace TekSQL.Field.MySql
{
    public class MySqlField : FieldBase, IMySqlField
    {
        private MySqlField(string name, string type) : base(name, type)
        {
        }

        internal MySqlField(string name, IMySqlFieldType type) : this(name, type.ToSqlString())
        {
        }
    }
}