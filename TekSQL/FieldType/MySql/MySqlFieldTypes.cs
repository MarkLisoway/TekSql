using System;
using System.Text;

namespace TekSQL.FieldType.MySql
{
    public sealed class MySqlFieldTypes
    {
        private readonly Func<int, MySqlFieldType> _bitSpecificFunc = bits => new MySqlFieldType($"BIT({bits})");

        private readonly Func<int?, int?, MySqlFieldType> _decimalSpecificFunc = delegate(int? precision, int? scale)
        {
            switch (precision)
            {
                case null when scale != null:
                    throw new ArgumentException(
                        $"{nameof(precision)} cannot be null while {nameof(scale)} is defined.",
                        nameof(precision));
                case null:
                    return new MySqlFieldType("DECIMAL()");
                default:
                    return scale == null
                        ? new MySqlFieldType($"DECIMAL({precision})")
                        : new MySqlFieldType($"DECIMAL({precision}, {scale})");
            }
        };

        private readonly Func<string[], MySqlFieldType> _enumFunc = delegate(string[] enums)
        {
            var enumBuilder = new StringBuilder("ENUM(");
            foreach (var @enum in enums) enumBuilder.Append($"{@enum}, ");

            // Remove last comma, and space characters
            enumBuilder.Remove(enumBuilder.Length - 2, 2);

            enumBuilder.Append(")");

            return new MySqlFieldType(enumBuilder.ToString());
        };

        private readonly Func<string[], MySqlFieldType> _setFunc = delegate(string[] sets)
        {
            var setBuilder = new StringBuilder("SET(");
            foreach (var set in sets) setBuilder.Append($"{set}, ");

            // Remove last comma, and space characters
            setBuilder.Remove(setBuilder.Length - 2, 2);

            setBuilder.Append(")");

            return new MySqlFieldType(setBuilder.ToString());
        };

        internal MySqlFieldTypes()
        {
        }

        public MySqlFieldType TinyInt => new MySqlFieldType("TINYINT");

        public MySqlFieldType SmallInt => new MySqlFieldType("SMALLINT");

        public MySqlFieldType MediumInt => new MySqlFieldType("MEDIUMINT");

        public MySqlFieldType Int => new MySqlFieldType("INT");

        public MySqlFieldType BigInt => new MySqlFieldType("BIGINT");

        public MySqlFieldType Decimal => DecimalSpecific(null, null);

        // MySql implements this data type the exact same as DECIMAL
        public MySqlFieldType Numeric => Decimal;

        public MySqlFieldType Float => new MySqlFieldType("FLOAT");

        public MySqlFieldType Double => new MySqlFieldType("DOUBLE");

        public MySqlFieldType Bit => new MySqlFieldType("BIT");

        public MySqlFieldType Date => new MySqlFieldType("DATE");

        public MySqlFieldType DateTime => new MySqlFieldType("DATETIME");

        public MySqlFieldType TimeStamp => new MySqlFieldType("TIMESTAMP");

        public MySqlFieldType Time => new MySqlFieldType("TIME");

        public MySqlFieldType Year => new MySqlFieldType("YEAR");

        public MySqlFieldType TinyBlob => new MySqlFieldType("TINYBLOB");

        public MySqlFieldType Blob => new MySqlFieldType("BLOB");

        public MySqlFieldType MediumBlob => new MySqlFieldType("MEDIUMBLOB");

        public MySqlFieldType LongBlob => new MySqlFieldType("LONGBLOB");

        public MySqlFieldType TinyText => new MySqlFieldType("TINYBLOB");

        public MySqlFieldType Text => new MySqlFieldType("BLOB");

        public MySqlFieldType MediumText => new MySqlFieldType("MEDIUMBLOB");

        public MySqlFieldType LongText => new MySqlFieldType("LONGBLOB");

        public MySqlFieldType Json => new MySqlFieldType("JSON");

        public MySqlFieldType DecimalSpecific(int? precision, int? scale)
        {
            return _decimalSpecificFunc(precision, scale);
        }

        // MySql implements this data type the exact same as DECIMAL
        public MySqlFieldType NumericSpecific(int? precision, int? scale)
        {
            return DecimalSpecific(precision, scale);
        }

        public MySqlFieldType BitSpecific(int bits)
        {
            return _bitSpecificFunc(bits);
        }

        public MySqlFieldType Char(int characters)
        {
            return new MySqlFieldType($"CHAR({characters})");
        }

        public MySqlFieldType VarChar(int characters)
        {
            return new MySqlFieldType($"VARCHAR({characters})");
        }

        public MySqlFieldType Binary(int bytes)
        {
            return new MySqlFieldType($"BINARY({bytes})");
        }

        public MySqlFieldType VarBinary(int bytes)
        {
            return new MySqlFieldType($"VARBINARY({bytes})");
        }

        public MySqlFieldType Enum(params string[] enums)
        {
            return _enumFunc(enums);
        }

        public MySqlFieldType Set(params string[] sets)
        {
            return _setFunc(sets);
        }
        
        /// <summary>
        /// This is to only be used under the circumstance that an explicit
        /// type does not currently exist.
        /// </summary>
        /// <param name="type">Type of the field, ie. VARCHAR(20), BLOB, or ENUM('Yes', 'No').</param>
        /// <returns><see cref="MySqlFieldType"/> corresponding to custom type string.</returns>
        public MySqlFieldType CustomOrUnSupportedType(string type) => new MySqlFieldType(type);
    }
}