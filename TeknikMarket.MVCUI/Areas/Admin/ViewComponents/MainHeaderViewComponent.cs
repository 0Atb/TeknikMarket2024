using Microsoft.AspNetCore.Mvc;

namespace TeknikMarket.MVCUI.Areas.Admin.ViewComponents
{
    public class MainHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
