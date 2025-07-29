using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 7: Create a Shape class with a method area().
    //Create two subclasses: Circle(radius) and Square(side) that override area().
    internal class Shape
    {
        public virtual double Area() // virtual method to allow overriding in subclasses
        {
            return 0;
        }
    }
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area() // Override the area method for Circle
        {
            return Math.PI * Radius * Radius; // Area of a circle: πr²
        }
    }
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side; // Area of a square: side²
        }
    }
}
