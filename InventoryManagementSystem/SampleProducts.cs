using InventoryManagementSystem.Products;
using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    public class SampleProducts
    {
        public static List<Product> Products()
        {
            return new List<Product> {
                new Chair("Four-legged Chair", 1299, 12, Color.Brown, Material.Wood),
                new Book("Clean Code", 2399, 15, "Robert C. Martin", 2008),
                new Pants("H&M Jeans", 4566, 19, Size.M, Color.Blue, Material.Denim),
                new Shoes("Adidas Sneakers", 6999, 20, 40),
                new Pot("Ikea Cooking Pot", 1299, 13, Material.Metal),
            };
        }
    }
}
