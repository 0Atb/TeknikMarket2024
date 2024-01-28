using Infrastructure.CrossCuttingConcern.MailOp;
using Microsoft.AspNetCore.Mvc;
using TeknikMarket.Model.Entity;
using TeknikMarket.Model.Static;
using TeknikMarket.Model.ViewModel.Area.Home;
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

        //[AktifKullaniciFilter]
        public IActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();

            //sitenin içine asp-for="" yazanların yerine veri gönderiyor

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            // sitenin içinden model dolu olarak geliyor onları işleme sokma yeri
            MailManager.Seed(model.Email, model.Subject,"Merhaba Sayın : " + model.Name +" "+ model.Message);



            return View(model);
        }
        public IActionResult Profile()
        {


            return View();
        }

    }
}