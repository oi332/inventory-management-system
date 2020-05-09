using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.Products
{
    public class Book : Product
    {
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string name, int price, int quantity, string author, int year) : base(name, price, quantity)
        {
            Year = year;
            Author = author;
        }

        public Book()
        {
        }

        public override void DetailedDisplay(int id)
        {
            Console.WriteLine($"ID: {id}");
            Utilities.DisplayPropertiesAndValues(this);
        }
    }
}
