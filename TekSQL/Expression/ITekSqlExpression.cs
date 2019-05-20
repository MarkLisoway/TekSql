namespace TekSQL.Expression
{
    public interface ITekSqlExpression
    {
        string Alias { get; }
        void As(string newAlias);
        string ToPartialQueryString();
    }
}