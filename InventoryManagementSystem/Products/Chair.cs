using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public class Chair : Product, IColor, IMaterial
    {
        public Color Color { get; set; }
        public Material Material { get; set; }

        public Chair(string name, int price, int quantity, Color color, Material material) : base(name, price, quantity)
        {
            Color = color;
            Material = material;
        }

        public Chair()
        {
        }

        public override void DetailedDisplay(int id)
        {
            Console.WriteLine($"ID: {id}");
            Utilities.DisplayPropertiesAndValues(this);
        }
    }
}
