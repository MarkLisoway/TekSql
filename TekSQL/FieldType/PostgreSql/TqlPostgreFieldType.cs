namespace TekSQL.FieldType.PostgreSql
{
    public class TqlPostgreFieldType : ITqlFieldType
    {
        private readonly string _type;
        
        internal TqlPostgreFieldType(string type)
        {
            _type = type;
        }

        public string ConvertTypeToString()
        {
            return _type;
        }
    }
}