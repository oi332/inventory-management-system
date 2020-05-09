using InventoryManagementSystem.Products;
using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    public static class ProductPropertiesCapture
    {
        private static void CaptureProductProperties(Product product)
        {
            Console.Write("Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Price (19.99 etc.): ");
            product.Price = Utilities.FormatPriceToCents(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
        }

        public static Chair CaptureChairProperties(Chair chair)
        {
            CaptureProductProperties(chair);

            CaptureMaterial(chair);

            CaptureColor(chair);

            return chair;
        }
        public static Pants CapturePantsProperties(Pants pants)
        {
            CaptureProductProperties(pants);

            CaptureMaterial(pants);

            CaptureColor(pants);

            CaptureSize(pants);

            return pants;
        }

        public static Shoes CaptureShoesProperties(Shoes shoes)
        {
            CaptureProductProperties(shoes);

            Console.Write("Size (43 etc.): ");
            shoes.Size = Convert.ToByte(Console.ReadLine());

            return shoes;
        }

        public static Pot CapturePotProperties(Pot pot)
        {
            CaptureProductProperties(pot);

            CaptureMaterial(pot);

            return pot;
        }

        public static Book CaptureBookProperties(Book book)
        {
            CaptureProductProperties(book);

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Year: ");
            book.Year = Convert.ToInt32(Console.ReadLine());

            return book;
        }

        private static void CaptureColor<T>(T t) where T : IColor
        {
            Console.Write($"Color ({Utilities.AvailableColors()}): ");
            t.Color = (Color)Enum.Parse(typeof(Color), Console.ReadLine(), true);
        }

        private static void CaptureMaterial<T>(T t) where T: IMaterial
        {
            Console.Write($"Material ({Utilities.AvailableMaterials()}): ");
            t.Material = (Material)Enum.Parse(typeof(Material), Console.ReadLine(), true);
        }

        private static void CaptureSize<T>(T t) where T : ISize
        {
            Console.Write($"Size ({Utilities.AvailableSizes()}): ");
            t.Size = (Size)Enum.Parse(typeof(Size), Console.ReadLine(), true);
        }
    }
}
