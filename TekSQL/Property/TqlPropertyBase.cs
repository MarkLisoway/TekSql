namespace TekSQL.Property
{
    public abstract class TqlPropertyBase : ITqlProperty
    {
        protected TqlPropertyBase(string propertyName, string propertyType)
        {
            PropertyName = propertyName;
            PropertyType = propertyType;
        }

        public string PropertyName { get; }

        public string PropertyType { get; }
    }
}