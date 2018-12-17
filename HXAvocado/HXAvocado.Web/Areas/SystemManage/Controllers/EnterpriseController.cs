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
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：企业信息管理控制器 
    /// </summary>
    public class EnterpriseController : Controller
    {
        private EnterpriseApp app = new EnterpriseApp();
        [HttpGet]
        public ActionResult Index()
        {
            var model = app.EnterpriseQuery();
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