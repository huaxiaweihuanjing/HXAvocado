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
    /// 描 述：模型修改接口 
    /// </summary>
    public interface IModificationAudited
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        string ID { get; set; }
        /// <summary>
        /// 修改该条记录的用户ID
        /// </summary>
        string LastModifyUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        DateTime? LastModifyTime { get; set; }
    }
}
