using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion_05
{

    /*
    Exercise 5: Create a Book class with attributes title, author, and price. 
    Add a method get_discounted_price(percent).
    */

    public class Book
    {
        public String title { get; set; }
        public String auther { get; set; }
        public double price { get; set;}
        public Book(String aTitle , String aAuther , double aPrice) 
        {
            
            title = aTitle;
            auther = aAuther;
            price = aPrice;


        }


        public void get_discounted_price()
        {
            //  I made the discount price random between 5% and 45%
            Random random = new Random();  
            double discount = random.Next(5,45);

            //  reving the discount money from the original price to get the price after discount
            double priceAfterDicount = price - (price * (discount / 100));

            Console.WriteLine($"we have a {discount}% discount\nso you can purches the book with only ${priceAfterDicount:F2}");

        }


    }
}
