using TekSQL.Expression;

namespace TekSQL.Property
{
    public abstract class TekSqlPropertyBase : TekSqlExpressionBase, ITekSqlProperty
    {
        protected TekSqlPropertyBase(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}