using SalesTaxes.Models;

namespace SalesTaxes.Models
{
    public class SalesOrder
    {
        private readonly List<Product> ShoppingBasket = [];

        public void AddProduct(Product product)
        {
            this.ShoppingBasket.Add(product);
        }

        /// <summary>
        /// Get the total tax of the sales order
        /// </summary>
        /// <returns>Total tax</returns>
        private decimal GetTotalTax()
        {
            decimal total = 0;

            foreach (Product product in ShoppingBasket)
            {
                total += product.GetTaxValue();
            }

            return total;
        }

        /// <summary>
        /// Get total cost of the sales order
        /// </summary>
        /// <returns>Total cost</returns>
        private decimal GetTotal()
        {
            decimal total = 0;

            foreach (Product product in ShoppingBasket)
            {
                total += product.GetTotalPrice();
            }

            return total;
        }

        /// <summary>
        /// Print receipt to the console
        /// </summary>
        public void PrintReceipt()
        {
            string text = "";

            // Add each product to the receipt
            foreach (Product product in ShoppingBasket)
            {
                text += "1 " + product.Name + ": " + product.GetTotalPrice().ToString("N2") + "\n";
            }

            // Add sales tax
            text += "Sales Taxes: " + this.GetTotalTax().ToString("N2") + "\n";

            // Add total
            text += "Total: " + this.GetTotal().ToString("N2") + "\n";

            // Output to console
            Console.WriteLine(text);
        }
    }
}