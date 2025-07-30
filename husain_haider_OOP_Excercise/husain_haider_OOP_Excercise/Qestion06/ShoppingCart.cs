using System;
using System.ComponentModel.Design;
using System.Xml.Linq;


namespace husain_haider_OOP_Excercise.Qestion06
{

    /*
     * Exercise 6: Create a ShoppingCart class that stores products (name and price). 
     * Add methods add_product(name, price), remove_product(name), and total_price().
     */

    public class ShoppingCart
    {

       
        public ShoppingCart() 
        {
            
        }

        private List<Products> CartOfProducts= new List<Products> ();

        public void add_product(String name, double price)
        {
            CartOfProducts.Add(new Products(name , price));
        }
        public void remove_product(String name) 
        {
            for(int i = CartOfProducts.Count-1; i>=0 ; i--)
            {
                if (CartOfProducts[i].name==name)
                    CartOfProducts.Remove(CartOfProducts[i]);
            
                else
                    Console.WriteLine("not item was found my that name continue shoing...");
                 
            }
            
      
        }

        
        public void total_price()
        {
            String itemRecipt = "";
            foreach (Products p in CartOfProducts)
            {
                itemRecipt += $"{p.name}\t\t\t$ {p.price:N2}\n";
            }


            double TotalePrice = 0;
            foreach (Products p in CartOfProducts)
            {
                TotalePrice += p.price;
            }
            Console.WriteLine($"""
===============================
          ITEM RECEIPT
===============================

Item                    Price
-------------------------------
{itemRecipt}                         
-------------------------------
TOTAL                   $ {TotalePrice:N2}
===============================
""");

        }
    }
}
