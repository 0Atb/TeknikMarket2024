using Microsoft.AspNetCore.Mvc;
using TeknikMarket.MVCUI.Areas.Admin.Fiter;

namespace TeknikMarket.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    // ---> Area/Contoller/action
    //[AktifKullaniciFilter]  //bütün rolleri kapsıyor
    [RolFilter("Admin")]  // sadece admin rolünde olan vatandaşlar girebilsin.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult Profile()
        {

            return View();
        }
    }
}