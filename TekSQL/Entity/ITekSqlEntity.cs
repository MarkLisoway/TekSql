namespace TekSQL.Entity
{
    /// <summary>
    ///     Represents the characteristics of an entity within the database.
    /// </summary>
    public interface ITekSqlEntity
    {
        /// <summary>
        ///     Name of the entity. NOT the name of the table.
        /// </summary>
        string EntityName { get; }
    }
}