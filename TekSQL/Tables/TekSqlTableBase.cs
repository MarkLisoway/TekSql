using System.Collections.Generic;
using System.Collections.ObjectModel;
using TekSQL.Entities;
using TekSQL.Properties;

namespace TekSQL.Tables
{
    /// <summary>
    /// Represents the configurations of a table which
    /// holds a specific entity.
    /// </summary>
    internal abstract class TekSqlTableBase
    {
        private readonly TekSqlEntityBase _entity;
        
        protected TekSqlTableBase(TekSqlEntityBase entity)
        {
            _entity = entity;
        }

        public TekSqlEntityBase Entity => _entity;
    }
}