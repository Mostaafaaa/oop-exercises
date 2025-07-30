using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Exercise 7: Create a Shape class with a method area(). Create two subclasses: 
Circle (radius) and Square (side) that override area().
*/


namespace husain_haider_OOP_Excercise.Qestion07
{
    internal class Square:Shape
    {
        public double side;
        public Square(double aSite) 
        {
            side = aSite;
        }
        public override double area()
        {
            return side*side ;
        }
    }
}
