using TekSQL.Field;

namespace TekSQL.Builder
{
    public abstract class TqlFieldBuilderBase<TType, TField> : ITqlFieldBuilder<TType, TField>
    where TField : class, ITqlField
    {
        protected string _name;

        protected TType _type;
        
        public ITqlFieldBuilder<TType, TField> Name(string name)
        {
            _name = name;
            return this;
        }

        public ITqlFieldBuilder<TType, TField> Type(TType type)
        {
            _type = type;
            return this;
        }

        public abstract TField Create();
    }
}