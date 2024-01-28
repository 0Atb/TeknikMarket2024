using Infrastructure.CrossCuttingConcern.Crypto;
using Infrastructure.CrossCuttingConcern.MailOp;
using Microsoft.AspNetCore.Mvc;
using TeknikMarket.Bussiness.Absract;
using TeknikMarket.Model.Static;
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

            Model.Entity.Admin admin = _adminBS.Get(x => x.Email == model.Email && x.Password == model.Password && x.IsDeleted == false);

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

                return Json(new { result = false, Mesaj = "Validasyon Hatası Oldu" });
            }

            string password = CryptoManager.SHA1Encrypt(CryptoManager.MD5Encrypt(model.Password));


            Model.Entity.Admin admin = _adminBS.Get(x => x.Email == model.Email && x.Password == password && x.IsDeleted == false, "AdminRoles", "AdminRoles.Role");

            if (admin != null)
            {

                //HttpContext.Session.Keys = ["admin"];

                session.AktifKullanici = admin;

                return Json(new { result = true, Mesaj = "Giriş Başarılı" });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Kullanıcı Bulunamadı." });
            }
        }
        public IActionResult NonAuthorization()
        {

            return View();
        }

        public IActionResult Logout()
        {

            session.AktifKullanici = null;

            return RedirectToAction("LogIn2", "Admin");
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
                MailManager.Seed(admin.Email, "Şifre Değiştirme", "Merhaba Sayın : " + admin.Name + " " + admin.LastName + "</br>Şifrenizi Değitirmek için Lütfen <a href='" + Keys.SITEADDRESS + "Admin/Admin/UpdatePassword?UniqueId=" + admin.UniqueId + "'>Tıklayınız</a>");


                return Json(new { result = true, Mesaj = "Şifre Değiştirme Linki Mail Adresinize Gönderildi.Lütfen Mailinizi Kontrol Ediniz." });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Bilgileriniz Hatalı. Lütfen Yeniden Deneyin" });
            }
        }

        public IActionResult UpdatePassword(string UniqueId)
        {
            UpdatePasswordViewModel model = new UpdatePasswordViewModel();

            model.UniqueId = UniqueId;

            Model.Entity.Admin admin = _adminBS.Get(x => x.UniqueId.ToString() == model.UniqueId);

            if (admin == null)
            {
                return RedirectToAction("DangerZone", "Admin");
            }


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult UpdatePassword(UpdatePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "Girdiğiniz Bilgiler Hatalı";

                return Json(new { result = false, Mesaj = "Validasyon Hatası Oldu" });
            }

            Model.Entity.Admin admin = _adminBS.Get(x => x.UniqueId.ToString() == model.UniqueId);

            if (admin != null && model.Password == model.ConfirmPassword)
            {
                admin.UniqueId = Guid.NewGuid();
                admin.Password = CryptoManager.SHA1Encrypt(CryptoManager.MD5Encrypt(model.Password));

                _adminBS.Update(admin);

                return Json(new { result = true, Mesaj = "Şifreniz Başarıyla Güncellendi." });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Bilgileriniz Hatalı. Lütfen Yeniden Deneyin" });
            }
        }

        public IActionResult DangerZone()
        {
            return View();
        }

    }
}
