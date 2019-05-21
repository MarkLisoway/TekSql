namespace TekSQL.Property.PostgreSql
{
    public static class TqlPostgreSql
    {
        /// <summary>
        ///     Creates a new PostgreSQL property.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyType">
        ///     Datatype of the property. Ensure you use string constants from here:
        ///     <see cref="PostgreSqlPropertyTypes" /> to ensure an invalid type is not used
        /// </param>
        /// <returns>New <see cref="TqlPostgreSqlProperty"/> property.</returns>
        public static TqlPostgreSqlProperty CreateProperty(string propertyName, string propertyType)
        {
            var newProperty = new TqlPostgreSqlProperty(propertyName, propertyType);
            return newProperty;
        }

        
        /// <summary>
        ///     Creates a new PostgreSQL property.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>New <see cref="TqlPostgreSqlProperty"/> property.</returns>
        public static TqlPostgreSqlProperty CreateProperty(string propertyName)
        {
            var newProperty = new TqlPostgreSqlProperty(propertyName, PostgreSqlPropertyTypes.DEFAULT);
            return newProperty;
        }
    }
}