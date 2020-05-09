using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InventoryManagementSystem
{
    public static class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Inventory Management System!");
            Console.WriteLine();
        }

        public static void Menu()
        {
            Console.WriteLine("1) List Inventory Products");
            Console.WriteLine("2) Add a Product");
            Console.WriteLine("3) Delete a Product");
            Console.WriteLine("4) Update Product's Quantity");
            Console.WriteLine("5) More Details About a Product");
            Console.WriteLine();
        }

        public static string CaptureInput()
        {
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void CustomMessage(string msg, int ms = 0)
        {
            if (ms != 0)
                Thread.Sleep(ms);

            Console.Write(msg);
        }

    }
}
