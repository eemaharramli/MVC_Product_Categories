using System.Collections.Generic;
using MVC_ProductsAndCategories_db.Models;

namespace MVC_ProductsAndCategories_db.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}