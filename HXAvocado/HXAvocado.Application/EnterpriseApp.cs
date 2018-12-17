using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HXAvocado.Data;
using HXAvocado.ViewModel;
using HXAvocado.Entity;

namespace HXAvocado.Application
{
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
            //EnterpriseViewModel enterpriseData = new EnterpriseViewModel();
            //if (ulits.Count == 0)
            //{
            //    enterpriseData.ID = "";
            //    enterpriseData.Name = "";
            //    enterpriseData.Content = "";
            //    enterpriseData.ServicePhone = "";
            //    enterpriseData.ServiceEmail = "";
            //    enterpriseData.Address = "";
            //    enterpriseData.DepositBank = "";
            //    enterpriseData.BankAccount = "";
            //}
            //else
            //{
            //    enterpriseData.ID = ulits.First().ID;
            //    enterpriseData.Name = ulits.First().Name;
            //    enterpriseData.Content = ulits.First().Content;
            //    enterpriseData.ServicePhone = ulits.First().ServicePhone;
            //    enterpriseData.ServiceEmail = ulits.First().ServiceEmail;
            //    enterpriseData.Address = ulits.First().Address;
            //    enterpriseData.DepositBank = ulits.First().DepositBank;
            //    enterpriseData.BankAccount = ulits.First().BankAccount;
            //}
            //return enterpriseData;
        }
    }
}
