using TekSQL.Field;
using TekSQL.FieldType;

namespace TekSQL.FieldBuilder
{
    public interface IFieldBuilder<in TType, out TField>
        where TType : class, IFieldType
        where TField : class, IField
    {
        IFieldBuilder<TType, TField> Name(string name);

        IFieldBuilder<TType, TField> Type(TType type);

        TField Create();
    }
}