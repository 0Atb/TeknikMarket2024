using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikMarket.Model.ViewModel.Area.Admin;

namespace TeknikMarket.Bussiness.ValidationRule.Area.Admin
{
    public class LogInViewModelValidator: AbstractValidator<LogInViewModel>
    {
        public LogInViewModelValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen Email Alanını Boş Bırakmayınız.").NotNull().WithMessage("Email Alanı Zorunlu").EmailAddress().WithMessage("Lütfen Email Formatında Giriniz.").Equal(x=>x.Email).WithMessage("Email Eşletmiyor.");

            RuleFor(x=>x.Password).NotEmpty().WithMessage("Lütfen Şifre Alanını Boş Bırakmayınız.").NotNull().WithMessage("Şifre Alanı Zorunlu").MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.").MaximumLength(15).WithMessage("Lütfen En fazla 15 karakter giriniz").Equal(x=>x.Password).WithMessage("Şifreler Eşleşmiyor.");
        }
    }
}
