using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXAvocado.Entity
{
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
