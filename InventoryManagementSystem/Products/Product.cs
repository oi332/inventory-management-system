using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }

        public Product()
        {
        }

        public virtual void DisplayLine(int id)
            => Console.WriteLine("{0,5} {1,10} {2,40} {3,10}$ {4,10}", id, this.GetType().Name, Name, Utilities.FormatPriceToEuros(Price), Quantity);


        public virtual void Display(int id)
            => Console.Write("{0,5} {1,10} {2,40} {3,10} {4,10}", id, this.GetType().Name, Name, Utilities.FormatPriceToEuros(Price), Quantity);

        public abstract void DetailedDisplay(int id);
    }
}
