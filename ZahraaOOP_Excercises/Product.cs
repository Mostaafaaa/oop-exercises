using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    // Exercise 15: Create a Product class with attributes name and price.
    // Create an Inventory class that manages multiple products with add_product() and list_products().

    internal class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public Product(string name, double price)
        {
            ProductName = name;
            ProductPrice = price;
        }
    }

    internal class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ListProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName} is ${product.ProductPrice}");
            }
        }
    }
}
