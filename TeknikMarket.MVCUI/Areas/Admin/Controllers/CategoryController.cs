using Microsoft.AspNetCore.Mvc;
using TeknikMarket.Bussiness.Absract;
using TeknikMarket.Model.Entity;
using TeknikMarket.Model.ViewModel.Area.Categories;

namespace TeknikMarket.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ICategoryBS _categoryBS;

        public CategoryController(ICategoryBS categoryBS)
        {
            _categoryBS = categoryBS;
        }

        public IActionResult List()
        {
            List<Category> categories = _categoryBS.GetAll().ToList();
            CategoryViewModel model = new CategoryViewModel();

            model.CategoriesList = categories;




            return View(model);
        }


    }
}
