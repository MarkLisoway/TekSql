namespace TekSQL.FieldType.PostgreSql
{
    public sealed class TqlPostgreFieldTypes
    {
        public TqlPostgreFieldType BigInt = new TqlPostgreFieldType("bigint");
        public TqlPostgreFieldType BigSerial = new TqlPostgreFieldType("bigserial");
        public TqlPostgreFieldType Bit = new TqlPostgreFieldType("bit");
        public TqlPostgreFieldType BitVarying = new TqlPostgreFieldType("bitvarying");
        public TqlPostgreFieldType Bool = new TqlPostgreFieldType("bool");
        public TqlPostgreFieldType Boolean = new TqlPostgreFieldType("boolean");
        public TqlPostgreFieldType Box = new TqlPostgreFieldType("box");
        public TqlPostgreFieldType Bytea = new TqlPostgreFieldType("bytea");
        public TqlPostgreFieldType Char = new TqlPostgreFieldType("char");
        public TqlPostgreFieldType Character = new TqlPostgreFieldType("character");
        public TqlPostgreFieldType CharacterVarying = new TqlPostgreFieldType("charactervarying");
        public TqlPostgreFieldType Cidr = new TqlPostgreFieldType("cidr");
        public TqlPostgreFieldType Circle = new TqlPostgreFieldType("circle");
        public TqlPostgreFieldType Date = new TqlPostgreFieldType("date");
        public TqlPostgreFieldType DoublePrecision = new TqlPostgreFieldType("doubleprecision");
        public TqlPostgreFieldType Float8 = new TqlPostgreFieldType("float8");
        public TqlPostgreFieldType INet = new TqlPostgreFieldType("inet");
        public TqlPostgreFieldType Int = new TqlPostgreFieldType("int");
        public TqlPostgreFieldType Int4 = new TqlPostgreFieldType("int4");
        public TqlPostgreFieldType Int8 = new TqlPostgreFieldType("int8");
        public TqlPostgreFieldType Integer = new TqlPostgreFieldType("integer");
        public TqlPostgreFieldType Serial8 = new TqlPostgreFieldType("serial8");
        public TqlPostgreFieldType VarBit = new TqlPostgreFieldType("varbit");
        public TqlPostgreFieldType VarChar = new TqlPostgreFieldType("varchar");
        public TqlPostgreFieldType Interval = new TqlPostgreFieldType("interval");                                                       
public TqlPostgreFieldType JSON = new TqlPostgreFieldType("json");                                                               
public TqlPostgreFieldType JSONB = new TqlPostgreFieldType("jsonb");                                                             
public TqlPostgreFieldType Line = new TqlPostgreFieldType("line");                                                               
public TqlPostgreFieldType LSeg = new TqlPostgreFieldType("lseg");                                                               
public TqlPostgreFieldType MACAddr = new TqlPostgreFieldType("macaddr");                                                         
public TqlPostgreFieldType Money = new TqlPostgreFieldType("money");                                                             
public TqlPostgreFieldType Numeric = new TqlPostgreFieldType("numeric");                                                         
public TqlPostgreFieldType Decimal = new TqlPostgreFieldType("decimal");                                                         
public TqlPostgreFieldType Path = new TqlPostgreFieldType("path");                                                               
public TqlPostgreFieldType PgLSN = new TqlPostgreFieldType("pglsn");                                                             
public TqlPostgreFieldType Point = new TqlPostgreFieldType("point");                                                             
public TqlPostgreFieldType Ploygon = new TqlPostgreFieldType("ploygon");                                                         
public TqlPostgreFieldType Real = new TqlPostgreFieldType("real");                                                               
public TqlPostgreFieldType Float4 = new TqlPostgreFieldType("float4");                                                           
public TqlPostgreFieldType SmallInt = new TqlPostgreFieldType("smallint");                                                       
public TqlPostgreFieldType Int2 = new TqlPostgreFieldType("int2");                                                               
public TqlPostgreFieldType SmallSerial = new TqlPostgreFieldType("smallserial");                                                 
public TqlPostgreFieldType Serial2 = new TqlPostgreFieldType("serial2");                                                         
public TqlPostgreFieldType Serial = new TqlPostgreFieldType("serial");                                                           
public TqlPostgreFieldType Serial4 = new TqlPostgreFieldType("serial4");                                                         
public TqlPostgreFieldType Text = new TqlPostgreFieldType("text");                                                               
public TqlPostgreFieldType Time(string fields, string span) => new TqlPostgreFieldType($"[{fields}][{span}]");                                                     
public TqlPostgreFieldType Time[P] = new TqlPostgreFieldType("time[p]");                                                         
public TqlPostgreFieldType TimeStamp[][] = new TqlPostgreFieldType("timestamp[][]");                                             
public TqlPostgreFieldType TimeStamp[] = new TqlPostgreFieldType("timestamp[]");                                                 
public TqlPostgreFieldType TSQuery = new TqlPostgreFieldType("tsquery");                                                         
public TqlPostgreFieldType TSVector = new TqlPostgreFieldType("tsvector");                                                       
public TqlPostgreFieldType TxIdSnapshot = new TqlPostgreFieldType("txidsnapshot");                                               
public TqlPostgreFieldType UUID = new TqlPostgreFieldType("uuid");                                                               
public TqlPostgreFieldType XML = new TqlPostgreFieldType("xml");

        internal TqlPostgreFieldTypes()
        {
        }
    }
}