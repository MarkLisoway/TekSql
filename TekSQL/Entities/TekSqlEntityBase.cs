using System.Collections.Generic;
using System.Collections.ObjectModel;
using TekSQL.Properties;

namespace TekSQL.Entities
{
    public abstract class TekSqlEntityBase
    {
        private readonly string _name;
        private readonly ICollection<TekSqlPropertyBase> _properties;

        protected TekSqlEntityBase(string name)
        {
            _name = name;
            _properties = new Collection<TekSqlPropertyBase>();
        }

        public string Name => _name;

        public void AddProperty(TekSqlPropertyBase property)
        {
            _properties.Add(property);
        }
    }
}