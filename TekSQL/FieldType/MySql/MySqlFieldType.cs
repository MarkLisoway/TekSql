namespace TekSQL.FieldType.MySql
{
    public sealed class MySqlFieldType : FieldTypeBase<string>, IMySqlFieldType
    {
        internal MySqlFieldType(string type) : base(type)
        {
        }
    }
}