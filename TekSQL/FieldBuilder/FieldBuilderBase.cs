using TekSQL.Field;
using TekSQL.FieldType;

namespace TekSQL.FieldBuilder
{
    public abstract class FieldBuilderBase<TType, TField> : IFieldBuilder<TType, TField>
        where TType : class, IFieldType
        where TField : class, IField
    {
        protected string FieldName;

        protected TType FieldType;

        public IFieldBuilder<TType, TField> Name(string name)
        {
            FieldName = name;
            return this;
        }

        public IFieldBuilder<TType, TField> Type(TType type)
        {
            FieldType = type;
            return this;
        }

        public abstract TField Create();
    }
}