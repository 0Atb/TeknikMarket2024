using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TeknikMarket.Model.Static;
using TeknikMarket.MVCUI.Extensions;

namespace TeknikMarket.MVCUI.Areas.Admin.Fiter
{
    public class RolFilter : ActionFilterAttribute
    {
        string[] ctrRoles;


        public RolFilter(params string[] roles)
        {
            ctrRoles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Sessionda Giriş Yapan Kişi
            Model.Entity.Admin admin = context.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);


            //Giriş yapan kişinin rollerini getir.
            string[] Rols = new string[admin.AdminRoles.Count]; //aktif kullanıcının etkin rollü
            for (int i = 0; i < admin.AdminRoles.Count; i++)
            {
                Rols[i] = admin.AdminRoles.ToList()[i].Role.RoleName;
            }

            bool Authorization = false;

            foreach (string role in Rols)   //Aktif Kullanıcının etkin rolleri
            {
                foreach (string r in ctrRoles)  //Controllardan gelen izin verilen rollere bak
                {
                    if (role==r)    //Aktif Kullanıcının rollerinde controllerdan izin verilen rollerde var mı. 
                    {
                        Authorization = true;
                    }
                }
            }


            if (!Authorization)
            {
                context.Result = new RedirectResult("/Admin/Admin/NonAuthorization");
            }




            base.OnActionExecuting(context);
        }


    }
}
