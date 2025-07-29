using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 3: Create a Rectangle class with attributes width and height. 
     * Add methods area() and perimeter() to calculate and return the values.*/
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
