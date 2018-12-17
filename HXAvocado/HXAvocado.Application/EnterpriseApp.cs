using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HXAvocado.Data;
using HXAvocado.ViewModel;
using HXAvocado.Entity;
using HXAvocado.Code;

namespace HXAvocado.Application
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：企业信息管理 
    /// </summary>
    public class EnterpriseApp
    {
        private HXAvocadoConnection db = new HXAvocadoConnection();

        public List< EnterpriseViewModel> EnterpriseQuery()
        {
            var enterprise = from e in db.EnterpriseEntitys
                                 // where e.Temp == "1"
                             select new EnterpriseViewModel
                             {
                                 ID =e.ID,
                                 Name=e.Name,
                                 Content=e.Content,
                                 ServicePhone=e.ServicePhone,
                                 ServiceEmail=e.ServiceEmail,
                                 Address=e.Address,
                                 DepositBank=e.DepositBank,
                                 BankAccount=e.BankAccount,
                             };


            var ulits = enterprise.ToList();
            if (ulits.Count == 0)
            {
                EnterpriseViewModel enterpriseData = new EnterpriseViewModel();
                enterpriseData.ID = "";
                enterpriseData.Name = "";
                enterpriseData.Content = "";
                enterpriseData.ServicePhone = "";
                enterpriseData.ServiceEmail = "";
                enterpriseData.Address = "";
                enterpriseData.DepositBank = "";
                enterpriseData.BankAccount = "";
                ulits.Add(enterpriseData);
            }
            return ulits;        
        }
        public void EnterpriseEdit(EnterpriseViewModel enterpriseData)
        {
            if (Ext.IsEmpty(enterpriseData.ID))
            {
                EnterpriseEntity enterpriseEntity = new EnterpriseEntity();
                enterpriseEntity.Name = enterpriseData.Name;
                enterpriseEntity.Content = enterpriseData.Content;
                enterpriseEntity.ServicePhone = enterpriseData.ServicePhone;
                enterpriseEntity.ServiceEmail = enterpriseData.ServiceEmail;
                enterpriseEntity.Address = enterpriseData.Address;
                enterpriseEntity.DepositBank = enterpriseData.DepositBank;
                enterpriseEntity.BankAccount = enterpriseData.BankAccount;
                enterpriseEntity.Create();
                db.EnterpriseEntitys.Add(enterpriseEntity);
                db.SaveChanges();
            }
            else
            {
                EnterpriseEntity enterpriseEntity = new EnterpriseEntity();
                enterpriseEntity.ID = enterpriseData.ID;
                db.EnterpriseEntitys.Attach(enterpriseEntity);
                enterpriseEntity.Modify(enterpriseData.ID);              
                enterpriseEntity.Name = enterpriseData.Name;
                enterpriseEntity.Content = enterpriseData.Content;
                enterpriseEntity.ServicePhone = enterpriseData.ServicePhone;
                enterpriseEntity.ServiceEmail = enterpriseData.ServiceEmail;
                enterpriseEntity.Address = enterpriseData.Address;
                enterpriseEntity.DepositBank = enterpriseData.DepositBank;
                enterpriseEntity.BankAccount = enterpriseData.BankAccount;
                db.SaveChanges();
            }
        }
    }
}
