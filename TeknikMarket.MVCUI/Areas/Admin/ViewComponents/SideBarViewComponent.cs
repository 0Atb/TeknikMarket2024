using Microsoft.AspNetCore.Mvc;

namespace TeknikMarket.MVCUI.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
