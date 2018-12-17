using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXAvocado.Entity
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：模型新建接口 
    /// </summary>
    public interface ICreationAudited
    {
        /// <summary>
        /// 主键
        /// </summary>
        string ID { get; set; }
        /// <summary>
        /// 创建用户的ID
        /// </summary>
        string CreatorUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime? CreatorTime { get; set; }
    }
}
