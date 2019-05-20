using TekSQL.Expression;

namespace TekSQL.Property
{
    public abstract class TekSqlPropertyBase : TekSqlExpressionBase, ITekSqlProperty
    {
        protected TekSqlPropertyBase(string propertyName, string propertyType) : base(propertyName)
        {
            PropertyName = propertyName;
            PropertyType = propertyType;
        }

        public string PropertyName { get; }
        
        public string PropertyType { get; }
    }
}