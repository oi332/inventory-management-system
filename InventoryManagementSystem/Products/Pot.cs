using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public class Pot : Product, IMaterial
    {
        public Material Material { get; set; }

        public Pot(string name, int price, int quantity, Material material) : base(name, price, quantity)
        {
            Material = material;
        }

        public Pot()
        {
        }

        public override void DetailedDisplay(int id)
        {
            Console.WriteLine($"ID: {id}");
            Utilities.DisplayPropertiesAndValues(this);
        }
    }
}
