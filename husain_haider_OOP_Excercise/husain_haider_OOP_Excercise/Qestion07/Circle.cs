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
    internal class Circle:Shape
    {
        double radius = 0;
        public Circle(double aRadius)
        {
            radius = aRadius;
        }
        public override double area()
        {
            return radius * radius * 3.14;
        }

    }
}
