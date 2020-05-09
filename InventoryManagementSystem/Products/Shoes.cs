using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public class Shoes : Product
    {
        public byte Size { get; set; }

        public Shoes(string name, int price, int quantity, byte size) : base(name, price, quantity)
        {
            Size = size;
        }

        public Shoes()
        {
        }

        public override void DetailedDisplay(int id)
        {
            Console.WriteLine($"ID: {id}");
            Utilities.DisplayPropertiesAndValues(this);
        }
    }
}
