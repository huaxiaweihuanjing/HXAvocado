using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXAvocado.Entity
{
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
