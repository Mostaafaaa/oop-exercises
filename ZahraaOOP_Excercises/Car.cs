using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 1: Create a Car class with attributes brand, model, and year. Add methods start() and stop(). 
     * Create 3 car objects and call their methods.*/
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public Car(string brand, string model, string year) 
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public void Start()
        {
            Console.WriteLine($"Start Method Works! {Brand} {Model} {Year}");
        }
        public void Stop() 
        { 
            Console.WriteLine($"Stop Method Works! {Brand} {Model} {Year}");
        }
    }
}
