using System.Collections;

namespace SalesTaxes.Models
{
    public enum ProductType
    {
        Book,
        Food,
        Medical,
        Other
    }

    public class Product(string name, ProductType type, decimal price, bool imported)
    {
        public string Name { get; } = name;
        private readonly ProductType Type = type;
        private readonly decimal Price = price;
        public bool Imported { get; } = imported;

        /// <summary>
        /// Get the tax value for this product
        /// </summary>
        /// <returns>Amount of tax to be paid</returns>
        public decimal GetTaxValue()
        {
            decimal taxRate;
            decimal tax;

            taxRate = this.Type switch
            {
                ProductType.Book or ProductType.Food or ProductType.Medical => 0, // Tax free
                ProductType.Other => 0.1m, // Standard tax
                _ => 0.1m // Use standard tax if type is not accounted for
            };

            if (this.Imported)
            {
                // Additional import tax
                taxRate += 0.05m;
            }

            // Calculate tax, rounding up to nearest 0.05
            tax = Math.Ceiling(this.Price * taxRate*20)/20;

            return tax;
        }

        /// <summary>
        /// Get the total price for this product including tax
        /// </summary>
        /// <returns>Price + tax</returns>
        public decimal GetTotalPrice()
        {
            decimal price;

            price = this.Price + this.GetTaxValue();

            return price;
        }
    }
}