namespace TekSQL.Expression
{
    /// <summary>
    /// Represents something that can be used as the parameters in query generation.
    /// This does NOT represent the high order functions such as:
    /// SELECT, WHERE, FROM, ON, JOIN, LIMIT, etc. Rather this represents
    /// lesser functions such as CONCAT, or STRING_AGG, and the parameters
    /// in higher order functions like the SELECT function.
    /// </summary>
    public interface ITekSqlExpression
    {
        /// <summary>
        /// The name used to give this expression when it is rendered into
        /// a query string.
        /// </summary>
        string ExpressionName { get; }
        
        /// <summary>
        /// Change the name of the expression when it is rendered.
        /// </summary>
        /// <param name="newName">New name (alias) to give the expression.</param>
        void As(string newName);
        
        /// <summary>
        /// Turn this expression into its equivalent query string.
        /// </summary>
        /// <returns>Query string which represents this expression.</returns>
        string ToPartialQueryString();
    }
}