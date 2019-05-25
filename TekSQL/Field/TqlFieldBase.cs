namespace TekSQL.Field
{
    public abstract class TqlFieldBase : ITqlField
    {
        protected TqlFieldBase(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}