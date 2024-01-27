using TeknikMarket.Model.Static;
using TeknikMarket.MVCUI.Extensions;

namespace TeknikMarket.MVCUI.Areas.Admin.Fiter
{
    public class SessionManager : ISessionManeger
    {
        IHttpContextAccessor httpContextAccessor;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Model.Entity.Admin AktifKullanici
        {
            get
            {
                return httpContextAccessor.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);
            }
            set 
            { 
                httpContextAccessor.HttpContext.Session.SetObject(SessionKeys.AktifKullanici, value);
            }
        }
    }
}
