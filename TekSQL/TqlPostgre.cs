using TekSQL.Builder.PostgreSql;
using TekSQL.FieldType.PostgreSql;

namespace TekSQL
{
    public static class TqlPostgre
    {
        public static TqlPostgreFieldBuilder Field => new TqlPostgreFieldBuilder();

        public static readonly TqlPostgreFieldTypes FieldTypes = new TqlPostgreFieldTypes();
    }
}