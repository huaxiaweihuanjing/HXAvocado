using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HXAvocado.Entity;

namespace HXAvocado.Data
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：连接字符串
    /// </summary>
    public class HXAvocadoConnection: DbContext
    {
        public HXAvocadoConnection() : base("name=HXAvocadoConnection") { }

        public DbSet<EnterpriseEntity> EnterpriseEntitys { get; set; }
    }
}
