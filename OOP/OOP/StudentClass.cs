using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*Exercise 2: Create a Student class with attributes name, age, and grade.
     * Add a method introduce() that prints the student details.*/
    internal class StudentClass
    {
        public String Name;
        public int Age;
        public double Grade;

        public void introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old and my grade is {Grade}.");
        }
    }
}
