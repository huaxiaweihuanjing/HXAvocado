using HXAvocado.Code;
using System.Web.Mvc;

namespace BoiledMeat.Web
{

    public abstract class ControllerBase : Controller
    {
      
        [HttpGet]


        protected virtual ActionResult Success(string message)
        {

            return Content(new AjaxResult { state = ResultType.success.ToString(), message = message }.ToJson());
        }
        protected virtual ActionResult Success(string message, object data)
        {
            return Content(new AjaxResult { state = ResultType.success.ToString(), message = message, data = data }.ToJson());
        }
        protected virtual ActionResult Error(string message)
        {

            return Content(new AjaxResult { state = ResultType.error.ToString(), message = message }.ToJson());
        }
    }
}
