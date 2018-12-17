using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HXAvocado.Application;
using HXAvocado.ViewModel;
using HXAvocado.Code;

namespace HXAvocado.Web.Areas.SystemManage.Controllers
{
    public class EnterpriseController : Controller
    {
        private EnterpriseApp app = new EnterpriseApp();
        [HttpGet]
        public ActionResult Index()
        {
            var model = app.EnterpriseQuery();
            //EnterpriseViewModel enterpriseViewModel = app.EnterpriseQuery();
            //ViewBag.ID = enterpriseViewModel.ID;
            //ViewBag.Name = enterpriseViewModel.Name;
            //ViewBag.Content = enterpriseViewModel.Content;
            //ViewBag.ServicePhone = enterpriseViewModel.ServicePhone;
            //ViewBag.ServiceEmail = enterpriseViewModel.ServiceEmail;
            //ViewBag.Address = enterpriseViewModel.Address;
            //ViewBag.DepositBank = enterpriseViewModel;
            //ViewBag.BankAccount = enterpriseViewModel;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnterprisePost(EnterpriseViewModel enterpriseData)
        {
            app.EnterpriseEdit(enterpriseData);
            return Content(new AjaxResult { state = ResultType.success.ToString(), message = "保存成功" }.ToJson());
        }
    }
}