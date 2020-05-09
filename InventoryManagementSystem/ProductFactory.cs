using InventoryManagementSystem.Products;
using InventoryManagementSystem.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem
{
    public static class ProductFactory
    {
        public static Product BuildProduct(string className) =>
            className switch
            {
                "Chair"     => ProductPropertiesCapture.CaptureChairProperties(new Chair()),
                "Book"      => ProductPropertiesCapture.CaptureBookProperties(new Book()),
                "Pants"     => ProductPropertiesCapture.CapturePantsProperties(new Pants()),
                "Shoes"     => ProductPropertiesCapture.CaptureShoesProperties(new Shoes()),
                "Pot"       => ProductPropertiesCapture.CapturePotProperties(new Pot()),
                _          => throw new ArgumentException(),
            };
    }
}
