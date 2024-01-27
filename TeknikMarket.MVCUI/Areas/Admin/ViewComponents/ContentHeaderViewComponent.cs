using Microsoft.AspNetCore.Mvc;

namespace TeknikMarket.MVCUI.Areas.Admin.ViewComponents
{
    public class ContentHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
