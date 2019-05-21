namespace TekSQL.Expression
{
    public abstract class TekSqlExpressionBase : ITekSqlExpression
    {
        protected TekSqlExpressionBase(string expressionName)
        {
            ExpressionName = expressionName;
        }

        public string ExpressionName { get; private set; }

        public void As(string newName)
        {
            ExpressionName = newName;
        }

        public abstract string ToPartialQueryString();
    }
}