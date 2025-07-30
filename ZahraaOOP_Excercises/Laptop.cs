using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 17: Create a Laptop class with attributes brand, processor, and RAM.
    //Add a method show_specs().

    internal class Laptop
    {
        public string Brand { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }

        public void ShowSpecs()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM} GB");
        }
    }
}
