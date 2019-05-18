namespace TekSQL.Properties
{
    /// <summary>
    /// Represents a single property (column) of a SQL entity.
    /// </summary>
    public abstract class TekSqlPropertyBase
    {
        /// <summary>
        /// Creates a TekSQL property.
        /// </summary>
        /// <param name="name">Name of property.</param>
        /// <param name="type">Datatype of property.</param>
        protected TekSqlPropertyBase(string name, string type)
        {
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Name of property (column header).
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Datatype of this property
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Overrides default object to string and returns
        /// the registered property name string.
        /// </summary>
        /// <returns>Registered property name string.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}