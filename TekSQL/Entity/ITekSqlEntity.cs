using System.Collections.Generic;
using TekSQL.Property;

namespace TekSQL.Entity
{
    public interface ITekSqlEntity
    {
        string Name { get; }
        IEnumerable<ITekSqlProperty> Properties { get; }
    }
}