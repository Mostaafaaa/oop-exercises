using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion13
{
    /*
    Exercise 3: Create a Rectangle class with attributes width and height. 
    Add methods area() and perimeter() to calculate and return the values.
    */
    public class Rectangle
    {
        public int width;
        public int height;


        public Rectangle(int Width,int Height) 
        {
            width = Width;
            height = Height;
        }

        public int area()
        {
            return width * height;
        }



        public int perimeter()
        {
            return width / height;
        }
    }
}
