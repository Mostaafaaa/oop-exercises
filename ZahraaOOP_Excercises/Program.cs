using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car BMW = new Car("Cadillac", "Escalade", "2025");
            BMW.Start();
            BMW.Stop();
            Car Audi = new Car("BMW", "Z5 Black", "2024");
            Audi.Start();
            Audi.Stop();
            Car Cadillac = new Car("Cadillac", "De Ville Convertible", "1966");
            Cadillac.Start();
            Cadillac.Stop();

            Console.WriteLine();

            Student Zetta = new Student("Zahraa", 22, "A+");
            Zetta.Introduce();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine($"Area of the rectangle: {rectangle.Area()}");
            Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter()}");

            Circle circle = new Circle(3.5);
            Console.WriteLine($"Area of the circle: {circle.Area()}");
            Square square = new Square(4);
            Console.WriteLine($"Area of the square: {square.Area()}");
        }
    }
}