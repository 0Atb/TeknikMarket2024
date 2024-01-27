using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TeknikMarket.Model.Static;
using TeknikMarket.MVCUI.Extensions;

namespace TeknikMarket.MVCUI.Areas.Admin.Fiter
{
    public class AktifKullaniciFilter:ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Not : Burası bu filterenin uygulandığı action method çalıştırılmadan önce çalışacak kodların yazılacağı yerdir.

            Model.Entity.Admin admin = context.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);

            if (admin==null)
            {
                context.Result = new RedirectResult("/Admin/Admin/LogIn2");
            }
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //Not : Burası bu filtrenin uygulandığı action method çalıştırıldıktan sonra çalışacak yerdir.
            base.OnActionExecuted(context);
        }
    }
}
