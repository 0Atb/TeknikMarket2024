using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikMarket.Model.ViewModel.Area.Admin
{
    public class LogInViewModel
    {
        //-----Data Annotations işlemleri yapıyoruz
        //[Required(ErrorMessage = "Lütfen Email Alanını Boş Girmeyiniz")]
        //[EmailAddress(ErrorMessage ="Lütfen geçerli bir Email Giriniz.")]
        public string? Email { get; set; }
        //[Required(ErrorMessage ="Lütfen Şifre Alanını Boş Girmeyiniz")]
        ////[MaxLength(16,ErrorMessage ="Maximum 16 karakter girebilirsiniz")]
        //[StringLength(16,ErrorMessage = "Maximum 16 karakter girebilirsiniz")]
        //[MinLength(3,ErrorMessage ="Minimum 3 karakter girebilirisiniz")]
        public string? Password { get; set; }
        public bool? RememberMe { get; set; }
    }
}
