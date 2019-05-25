using TekSQL.Field.PostgreSql;
using TekSQL.FieldType.PostgreSql;

namespace TekSQL.Builder.PostgreSql
{
    public sealed class TqlPostgreFieldBuilder : TqlFieldBuilderBase<TqlPostgreFieldType, TqlPostgreField>
    {
        internal TqlPostgreFieldBuilder()
        {
        }
        
        public override TqlPostgreField Create()
        {
            return new TqlPostgreField(_name, _type.ConvertTypeToString());
        }
    }
}