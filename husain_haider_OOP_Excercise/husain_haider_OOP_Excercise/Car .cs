using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise
{
    public class Car
    {
        public String brand;
        public String model;
        public int year;
        public static int NumberOfCars;

        public Car(String aBrand,String aModel,int aYear)
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
