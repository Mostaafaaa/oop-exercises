using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaOmar_oopExcercise
{
    internal class Car
    {
        //  Exercise 1: Create a Car class with attributes brand, model, and year.
        //  Add methods start() and stop().
        //  Create 3 car objects and call their methods.
        //  
         string Brand;
         string Model;
         int Year;

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year  = year;

            DisplayCarInfo();
            Console.WriteLine("---- Has Been Added ----\n");
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("---- The Car of ----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }

        public void Start()
        {
            DisplayCarInfo();
            Console.WriteLine("---- Has started ----\n");
        }
        public void Stop()
        {
            DisplayCarInfo();
            Console.WriteLine("!!!Has Stopped!!!\n");
        }


    }
}
