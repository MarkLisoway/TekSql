namespace TekSQL.Property
{
    public abstract class TekSqlPropertyBase : ITekSqlProperty
    {
        protected TekSqlPropertyBase(string propertyName, string propertyType)
        {
            PropertyName = propertyName;
            PropertyType = propertyType;
        }

        public string PropertyName { get; }

        public string PropertyType { get; }
    }
}