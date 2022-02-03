using System;

namespace MVC_ProductsAndCategories_db.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private readonly int _price = new Random().Next(1, 100);
        public Category Category { get; set; }


        public override string ToString()
        {
            return $"Product name: {this.Name}, Product ID: {this.Id}, Product Price: {this._price}, Product Category: {Category.Name}";
        }
    }
}