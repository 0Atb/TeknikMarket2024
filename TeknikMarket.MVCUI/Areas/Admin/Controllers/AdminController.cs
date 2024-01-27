using Microsoft.AspNetCore.Mvc;
using TeknikMarket.Bussiness.Absract;
using TeknikMarket.Model.ViewModel.Area.Admin;
using TeknikMarket.MVCUI.Areas.Admin.Fiter;

namespace TeknikMarket.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        IAdminBS _adminBS;
        ISessionManeger session;

        public AdminController(IAdminBS adminBS, ISessionManeger _session)
        {
            _adminBS = adminBS;
            session = _session;
        }

        public IActionResult LogIn()
        {
            LogInViewModel model = new LogInViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult LogIn(LogInViewModel model)
        {
            if (!ModelState.IsValid) //ModelState.IsValid propu, validasyonlardan verinin geçip geçmediği bilgisini bize verir. Bu sayede sunucuda gereksiz kod çalışmaz.
            {
                ViewBag.Mesaj = "Girdiğiniz Bilgiler Hatalı";

                return View(model);
            }

            Model.Entity.Admin admin = _adminBS.Get(x => x.Email == model.Email && x.Password == model.Password && x.IsDeleted==false);

            if (admin != null)
            {

                return RedirectToAction("Index", "Home");

                //return Redirect("/Admin/Home/Index");
            }
            ViewBag.Mesaj = "Giriş Başarısız";

            return View(model);
        }



        public IActionResult LogIn2()
        {
            LogInViewModel model = new LogInViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult LogIn2(LogInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "Girdiğiniz Bilgiler Hatalı";

                return Json(new { result = false,Mesaj="Validasyon Hatası Oldu" }); 
            }

            Model.Entity.Admin admin = _adminBS.Get(x => x.Email == model.Email && x.Password == model.Password && x.IsDeleted == false, "AdminRoles", "AdminRoles.Role");

            if (admin != null)
            {

                //HttpContext.Session.Keys = ["admin"];

                session.AktifKullanici = admin;

                return Json(new { result = true ,Mesaj="Giriş Başarılı"});
            }
            else
            {
                return Json(new { result = false ,Mesaj="Kullanıcı Bulunamadı."});
            }
        }
        public IActionResult NonAuthorization()
        {
            
            return View();
        }

        public IActionResult Logout()
        {

            session.AktifKullanici = null;

            return RedirectToAction("LogIn2","Admin");
        }

        public IActionResult ForgotPassword() 
        {
            ForgotPasswordViewModel model = new ForgotPasswordViewModel();


            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "Girdiğiniz Bilgiler Hatalı";

                return Json(new { result = false, Mesaj = "Validasyon Hatası Oldu" });
            }

            Model.Entity.Admin admin = _adminBS.Get(x => x.Email == model.Email);

            if (admin != null) 
            {

                //Mail işlemleri



                return Json(new { result = true, Mesaj = "Şifre Değiştirme Linki Mail Adresinize Gönderildi.Lütfen Mailinizi Kontrol Ediniz." });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Bilgileriniz Hatalı. Lütfen Yeniden Deneyin" });
            }

            
        }
    }
}
