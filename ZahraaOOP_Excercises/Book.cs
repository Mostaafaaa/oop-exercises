using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 5: Create a Book class with attributes title, author, and price. 
     * Add a method get_discounted_price(percent). */
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Book(string title, string author, double price) 
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public double GetDiscountedPrice(double percent)
        {
            if (percent < 0 || percent > 100)
            {
                Console.WriteLine("Discount percent is not sensaible!");
                return Price;
            }
            double discount = Price * (percent / 100); // example: 20% discount on a $50 book = $10 discount (50 * 0.20)
            return Price - discount;
        }
    }
}
