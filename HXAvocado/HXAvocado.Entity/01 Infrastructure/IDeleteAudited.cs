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
    /// 描 述：模型逻辑删除接口 
    /// </summary>
    public interface IDeleteAudited
    {
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        bool? DeleteMark { get; set; }

        /// <summary>
        /// 删除实体的用户
        /// </summary>
        string DeleteUserId { get; set; }

        /// <summary>
        /// 删除实体时间
        /// </summary>
        DateTime? DeleteTime { get; set; }
    }
}
