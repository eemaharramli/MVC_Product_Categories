using System.Collections;
using System.Collections.Generic;

namespace MVC_ProductsAndCategories_db.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

        
        public override string ToString()
        {
            return $"Category id: {this.Id}, Category Name: {this.Name}";
        }
    }
}