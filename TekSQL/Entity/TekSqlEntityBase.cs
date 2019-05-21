namespace TekSQL.Entity
{
    public abstract class TekSqlEntityBase : ITekSqlEntity
    {
        protected TekSqlEntityBase(string entityName)
        {
            EntityName = entityName;
        }

        public string EntityName { get; }
    }
}