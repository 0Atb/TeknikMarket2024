using FluentValidation;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;
using TeknikMarket.Bussiness.Absract;
using TeknikMarket.Bussiness.Concrete;
using TeknikMarket.Bussiness.ValidationRule.Area.Admin;
using TeknikMarket.DataAccess.Absract;
using TeknikMarket.DataAccess.Concrete.EntityFramework.Repository;
using TeknikMarket.Model.ViewModel.Area.Admin;
using TeknikMarket.MVCUI.Areas.Admin.Fiter;

namespace TeknikMarket.MVCUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddFluentValidationClientsideAdapters();

            builder.Services.AddSingleton<IAdminBS, AdminBS>();
            builder.Services.AddSingleton<IAdminRepository, EfAdminRepository>();



            //-----------SESSION
            builder.Services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
             });
            builder.Services.AddSingleton<ISessionManeger, SessionManager>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //-----------VALIDATION
            builder.Services.AddSingleton<IValidator<LogInViewModel>, LogInViewModelValidator>();





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            });



            app.Run();
        }
    }
}