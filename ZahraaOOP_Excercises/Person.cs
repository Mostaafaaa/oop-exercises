using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{

    /*Exercise 10: Create a Person class with attributes name and age. 
     * Create a method greet(). Create an Employee subclass with an additional attribute salary.*/
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    internal class Employee : Person
    {
        public double Salary { get; set; }
    }
}
