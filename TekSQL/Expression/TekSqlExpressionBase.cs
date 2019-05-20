namespace TekSQL.Expression
{
    public abstract class TekSqlExpressionBase : ITekSqlExpression
    {
        protected TekSqlExpressionBase()
        {
            Alias = null;
        }

        public string Alias { get; private set; }

        public void As(string newAlias)
        {
            Alias = newAlias;
        }

        public abstract string ToPartialQueryString();
    }
}