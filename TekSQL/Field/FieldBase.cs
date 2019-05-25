namespace TekSQL.Field
{
    public abstract class FieldBase : IField
    {
        protected FieldBase(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}