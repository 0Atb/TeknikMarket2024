using Microsoft.AspNetCore.Mvc;

namespace TeknikMarket.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
