using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public class Pants : Product, IColor, IMaterial, ISize
    {
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Material Material { get; set; }

        public Pants(string name, int price, int quantity, Size size, Color color, Material material) : base(name, price, quantity)
        {
            Color = color;
            Size = size;
            Material = material;
        }

        public Pants()
        {
        }

        public override void DetailedDisplay(int id)
        {
            Console.WriteLine($"ID: {id}");
            Utilities.DisplayPropertiesAndValues(this);
        }

    }
}
