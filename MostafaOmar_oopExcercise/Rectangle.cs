using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaOmar_oopExcercise
{
    internal class Rectangle
    {
        // Exercise 3: Create a Rectangle class with attributes width and height.
        // Add methods area() and perimeter() to calculate and return the values.
        //
        //
        float Width;
        float Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        // Method to calculate area
        public float Area()
        {
            return Width * Height;
        }

        // Method to calculate perimeter
        public float Perimeter()
        {
            return 2 * (Width + Height);
        }

        public void RectangleInfo()
        {
            Console.WriteLine("---- Rectangle Info ----");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
    }
}
