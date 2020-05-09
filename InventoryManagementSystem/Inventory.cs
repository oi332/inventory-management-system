using InventoryManagementSystem.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private readonly List<Product> Products = new List<Product>();
        private readonly List<string> ProductTypes;

        public Inventory()
        {
            ProductTypes = GetProductTypes();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProductTypes() {
            for (var i = 0; i < ProductTypes.Count; i++)
            {
                Console.WriteLine($"{i}) {ProductTypes[i]}");
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("{0,5} {1,10} {2,40} {3,10} {4,10}", "ID", "Type", "Product Name", "Price", "Quantity");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            for (var i = 0; i < Products.Count; i++)
            {
                Products[i].DisplayLine(i);
            }
        }

        public void DisplayProduct(int id)
        {
            if (IsValidId(id, Products))
                Products[id].DetailedDisplay(id);
            Console.WriteLine();
        }

        public string GetProductType(int id)
        {
            if(IsValidId(id, ProductTypes))
                return ProductTypes[id];

            return "";
        }

        public void RemoveProduct(int id)
        {
            if (IsValidId(id, Products))
                Products.RemoveAt(id);
        }

        public void UpdateProductQuantity(int id, int amount)
        {
            if (!IsValidId(id, Products))
                return;

            var productQuantityAfterUpdate = Products[id].Quantity + amount;

            switch (productQuantityAfterUpdate)
            {
                case int n when n == 0:
                    Products.RemoveAt(id);
                    break;
                case int n when n < 0:
                    break;
                case int n when n > 0:
                    Products[id].Quantity += amount;
                    break;
            }
        }

        private bool IsValidId<T>(int id, List<T> list)
        {
            return id >= 0 && id < list.Count;
        }

        private List<string> GetProductTypes()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(assembly => assembly.GetTypes())
               .Where(type => type.IsSubclassOf(typeof(Product)))
               .Select(type => type.Name)
               .ToList();
        }

    }
}
