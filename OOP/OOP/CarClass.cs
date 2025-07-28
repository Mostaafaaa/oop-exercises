using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class CarClass
    {
        /*Exercise 1: Create a Car class with attributes brand, model, and year. Add methods start() and stop().
         * Create 3 car objects and call their methods.
         */
        public String brand;
        public String model;   
        public int year;

        public void start()
        {
                       Console.WriteLine($"The {brand} {model} ({year}) is starting.");
        }

        public void stop()
        {
            Console.WriteLine($"The {brand} {model} ({year}) is stopping.");
        }

    }
}
