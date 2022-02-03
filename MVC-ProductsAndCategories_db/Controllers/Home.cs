using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_ProductsAndCategories_db.Models;
using MVC_ProductsAndCategories_db.ViewModels;

namespace MVC_ProductsAndCategories_db.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {

            var laptop = new Category {Id = 1, Name = "Laptop"};
            var imac = new Category {Id = 2, Name = "IMac"};
            var iphone = new Category {Id = 3, Name = "IPhone"};
            
            var products = new List<Product>
            {
                new Product{Id = 1, Name = "Macbook", Category = laptop},
                new Product{Id = 2, Name = "IMac", Category = imac},
                new Product{Id = 3, Name = "IPhone", Category = iphone},
            };

            var categories = new List<Category>
            {
                new Category{Id = 1, Name = "Laptop"},
                new Category{Id = 2, Name = "IMac"},
                new Category{Id = 3, Name = "IPhone"}
            };

            return View(new HomeViewModel
            {
                Products = products,
                Categories = categories
            });
        }

        public IActionResult Detail()
        {
            Category laptop = new Category{Id = 1, Name = "Laptop"};
            return View(new Product{Id = 1, Name = "Macbook", Category = laptop});
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}