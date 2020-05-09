using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    public static class Utilities
    {
        public static decimal FormatPriceToEuros(int price)
            => (decimal)price / 100;

        public static int FormatPriceToCents(double price)
            => (int)(price * 100);

        public static string AvailableMaterials()
            => string.Join(", ", Enum.GetNames(typeof(Material)));

        public static string AvailableColors()
            => string.Join(", ", Enum.GetNames(typeof(Color)));

        public static string AvailableSizes() 
            => string.Join(", ", Enum.GetNames(typeof(Size)));

        public static void DisplayPropertiesAndValues(object o)
        {
            foreach (var prop in o.GetType().GetProperties())
            {
                if (prop.Name == "Price")
                {
                    Console.WriteLine($"{prop.Name}: {FormatPriceToEuros(Convert.ToInt32(prop.GetValue(o)))}$");
                    continue;
                }

                Console.WriteLine($"{prop.Name}: {prop.GetValue(o)}");
            }
        }
    }
}
