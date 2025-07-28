using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*Exercise 3: Create a Rectangle class with attributes width and height. 
     * Add methods area() and perimeter() to calculate and return the values.
*/
    internal class RectangleClass
    {
        public double width;
        public double height;

        public double area()
        {

            return width * height;
            
        }

        public double perimeter()
        {
            return 2 * (width + height);
        }
    }
}
