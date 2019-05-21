namespace TekSQL.Property
{
    /// <summary>
    ///     Represents a single property of an entity that is stored in a database.
    /// </summary>
    public interface ITqlProperty
    {
        /// <summary>
        ///     Represents the name of this property in the database.
        ///     In other words, this represents the name of the database column.
        /// </summary>
        string PropertyName { get; }

        /// <summary>
        ///     String literal of the type of this property.
        ///     For example, PostgreSQL has types 'CHAR', 'UUID',
        ///     'HSTORE', etc.
        /// </summary>
        string PropertyType { get; }
    }
}