using TeknikMarket.Model.Entity;
//using Microsoft.AspNetCore.Mvc.Rendering;


namespace TeknikMarket.Model.ViewModel.Area.Categories
{
    public class CategoryViewModel
    {
        //Kategoriyi Listelemek için
        public List<Category> CategoriesList { get; set; }

        //Kategori Ekleme İşlemi için
        //public List<SelectListItem> CategorySelectList { get; set; }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? MainCategoryId { get; set; }
        public string? Information { get; set; }
        public int? Sorting { get; set; }
        public bool IsDeleted { get; set; }
    }
}
