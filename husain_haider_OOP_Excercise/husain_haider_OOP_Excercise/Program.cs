using System.Reflection;

namespace husain_haider_OOP_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Qstion: ");
            Console.WriteLine("------------");


            //brand = Toyota;
            //model = Supra;
            //year = 2023;
            Car car1 = new Car("Toyota", "Supra", 2023);

            //brand = Ford;
            //model = Mustang;
            //year = 2021;
            Car car2 = new Car("Ford", "Mustang", 2021);

            //brand = Porsche;
            //model = 911;
            //year = 2022;
            Car car3 = new Car("Porsche", "911", 2022);



            //  calling cars methodes
            
        }
    }
}
