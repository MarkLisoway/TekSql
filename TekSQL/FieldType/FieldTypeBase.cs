namespace TekSQL.FieldType
{
    public abstract class FieldTypeBase<T> : IFieldType
    {
        private readonly T _type;

        protected FieldTypeBase(T type)
        {
            _type = type;
        }
        
        public virtual string ToSqlString()
        {
            return _type.ToString();
        }
    }
}