using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HXAvocado.Entity
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：企业管理模型 
    /// </summary>
    public class EnterpriseEntity : IEntity<EnterpriseEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [Required]
        [MaxLength(50)]
        public string ID { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        /// <summary>
        /// 企业描述
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 服务电话
        /// </summary>
        [MaxLength(20)]
        public string ServicePhone { get; set; }
        /// <summary>
        /// 服务邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(256)]
        public string ServiceEmail { get; set; }
        /// <summary>
        /// 企业地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        public string DepositBank { get; set; }
        /// <summary>
        /// 银行账户
        /// </summary>
        [MaxLength(50)]
        public string BankAccount { get; set; }
        /// <summary>
        /// 创建用户的ID
        /// </summary>
        [MaxLength(50)]
        public string CreatorUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatorTime { get; set; }
        /// <summary>
        /// 修改该条记录的用户ID
        /// </summary>
        [MaxLength(50)]
        public string LastModifyUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? LastModifyTime { get; set; }
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        public bool? DeleteMark { get; set; }
        /// <summary>
        /// 删除实体的用户
        /// </summary>
        [MaxLength(50)]
        public string DeleteUserId { get; set; }
        /// <summary>
        /// 删除实体时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }

    }
}
