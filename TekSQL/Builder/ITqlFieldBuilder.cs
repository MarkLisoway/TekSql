using TekSQL.Field;

namespace TekSQL.Builder
{
    public interface ITqlFieldBuilder<in TType, out TField>
    where TField : class, ITqlField
    {
        ITqlFieldBuilder<TType, TField> Name(string name);

        ITqlFieldBuilder<TType, TField> Type(TType type);

        TField Create();
    }
}