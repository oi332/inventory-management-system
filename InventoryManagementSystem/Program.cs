using InventoryManagementSystem.Products;
using InventoryManagementSystem.Products.Attributes;
using System;
using System.Linq;
using System.Threading;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main()
        {
            var inventory = new Inventory(SampleProducts.Products());

            Messages.Welcome();
            string menuOption;

            do
            {
                Messages.Clear();
                Messages.Menu();

                Messages.CustomMessage("Choose your option(-1 to exit): ");
                menuOption = Messages.CaptureInput();

                Messages.Clear();

                switch (menuOption)
                {
                    case "1":
                        inventory.DisplayProducts();

                        Messages.CustomMessage("Enter to go back to menu: ");
                        Messages.CaptureInput();

                        break;
                    case "2":
                        inventory.DisplayProductTypes();

                        Messages.CustomMessage("Enter your choice: ");

                        var productTypeId = Convert.ToInt32(Messages.CaptureInput());

                        try
                        {
                            var product = ProductFactory.BuildProduct(inventory.GetProductType(productTypeId));
                            inventory.AddProduct(product);

                            Messages.Clear();
                            Messages.CustomMessage("Product has been successfully added.", 1000);
                        }
                        catch
                        {
                            Messages.Clear();
                            Messages.CustomMessage("Failed to create a Product", 1000);
                        }

                        break;
                    case "3":
                        Messages.CustomMessage("Enter Product ID for removal: ");
                        var productToRemoveId = Convert.ToInt32(Messages.CaptureInput());

                        inventory.RemoveProduct(productToRemoveId);

                        break;
                    case "4":
                        Messages.CustomMessage("Enter Product ID for update: ");
                        var productToUpdateId = Convert.ToInt32(Messages.CaptureInput());

                        Messages.CustomMessage("Enter amount by which to update: ");
                        var amountToUpdateWith = Convert.ToInt32(Messages.CaptureInput());

                        inventory.UpdateProductQuantity(productToUpdateId, amountToUpdateWith);

                        break;
                    case "5":
                        Messages.CustomMessage("Enter Product ID for more details about a Product: ");
                        var productToDisplay = Convert.ToInt32(Messages.CaptureInput());

                        Messages.Clear();

                        inventory.DisplayProduct(productToDisplay);

                        Messages.CustomMessage("Enter to go back to menu: ");
                        Messages.CaptureInput();

                        break;
                    default:
                        return;
                }

            } while (menuOption != "-1");
        }
    }
}
