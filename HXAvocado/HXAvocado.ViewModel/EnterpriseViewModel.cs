using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXAvocado.ViewModel
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：企业信息管理视图模型
    /// </summary>
    public class EnterpriseViewModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 企业描述
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 服务电话
        /// </summary>
        public string ServicePhone { get; set; }
        /// <summary>
        /// 服务邮箱
        /// </summary>
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
        public string BankAccount { get; set; }
    }
}
