using TekSQL.Field.MySql;
using TekSQL.FieldType.MySql;

namespace TekSQL.FieldBuilder.MySql
{
    public class MySqlFieldBuilder : FieldBuilderBase<IMySqlFieldType, IMySqlField>
    {
        public override IMySqlField Create()
        {
            return new MySqlField(FieldName, FieldType);
        }
    }
}