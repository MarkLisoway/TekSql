namespace TekSQL.Property.PostgreSql
{
    /// <summary>
    ///     All PostgreSQL data types as of 2019-05-20.
    ///     Referencing documentation here: <see cref="https://www.postgresql.org/docs/9.5/datatype.html"/>.
    /// </summary>
    public static class PostgreSqlPropertyTypes
    {
        /// <summary>
        ///     If a property is registered with no type,
        ///     this is used.
        /// </summary>
        internal static string DEFAULT => VarChar(32);

        public static string BigInt => "int8";

        public static string BigSerial => "serial8";

        public static string Boolean => "boolean";

        public static string Box => "box";

        public static string ByteArray => "bytea";

        public static string Bit(int size)
        {
            return $"big[{size}]";
        }

        public static string BitVarying(int size)
        {
            return $"varbit[{size}]";
        }

        public static string Char(int size)
        {
            return $"char[{size}]";
        }

        public static string VarChar(int size)
        {
            return $"varchar[{size}]";
        }
    }

    public enum test
    {
        TEST(int size),
        
    }
}