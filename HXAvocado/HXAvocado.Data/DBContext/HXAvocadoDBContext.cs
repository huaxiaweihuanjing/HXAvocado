using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HXAvocado.Entity;

namespace HXAvocado.Data
{
    public class HXAvocadoConnection: DbContext
    {
        public HXAvocadoConnection() : base("name=HXAvocadoConnection") { }

        public DbSet<EnterpriseEntity> EnterpriseEntitys { get; set; }
    }
}
