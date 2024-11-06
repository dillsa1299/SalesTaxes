using SalesTaxes.Models;

namespace SalesTaxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order1();
            Order2();
            Order3();
        }

        static void Order1()
        {
            SalesOrder salesOrder = new();
            Product product;

            Console.WriteLine("Output 1:");

            // Add products
            product = new("Book",ProductType.Book,12.49m,false);
            salesOrder.AddProduct(product);

            product = new("Music CD",ProductType.Other,14.99m,false);
            salesOrder.AddProduct(product);

            product = new("Chocolate bar",ProductType.Food,0.85m,false);
            salesOrder.AddProduct(product);

            // Print receipt
            salesOrder.PrintReceipt();
        }

        static void Order2()
        {
            SalesOrder salesOrder = new();
            Product product;

            Console.WriteLine("Output 2:");

            // Add products
            product = new("Imported box of chocolates",ProductType.Food,10.00m,true);
            salesOrder.AddProduct(product);

            product = new("Imported bottle of perfume",ProductType.Other,47.50m,true);
            salesOrder.AddProduct(product);

            // Print receipt
            salesOrder.PrintReceipt();
        }

        static void Order3()
        {
            SalesOrder salesOrder = new();
            Product product;

            Console.WriteLine("Output 3:");

            // Add products
            product = new("Imported bottle of perfume",ProductType.Other,27.99m,true);
            salesOrder.AddProduct(product);

            product = new("Bottle of perfume",ProductType.Other,18.99m,false);
            salesOrder.AddProduct(product);

            product = new("Packet of paracetamol",ProductType.Medical,9.75m,false);
            salesOrder.AddProduct(product);

            product = new("Box of imported chocolates",ProductType.Food,11.25m,true);
            salesOrder.AddProduct(product);

            // Print receipt
            salesOrder.PrintReceipt();
        }
    }
}