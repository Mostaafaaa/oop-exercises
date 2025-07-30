using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion1
{
            /*
            * Exercise 1: Create a Car class with attributes brand, model, and year. 
            * Add smethods start() and stop(). Create 3 car objects and call their methods.
            */
    public class Car
    {
        public string brand;
        public string model;
        public int year;
        public static int NumberOfCars;

        public Car(string aBrand,string aModel,int aYear)
        {
            brand = aBrand;
            model = aModel;
            year = aYear;
            NumberOfCars++;
            info();
            start();
            stop();
            Console.WriteLine();
        }

        //  printing car information
        public void info()
        {
         
            
            Console.WriteLine($"car details: -> {brand} - {model} - {year}");
        }
       

        public void start()
        {
            Console.WriteLine("car is starting ...");
        }
        public void stop() { Console.WriteLine("car has stoped !!!"); }
    }
}
