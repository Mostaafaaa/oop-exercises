using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 18: Create a Teacher class with attributes name, subject, and salary. Add a method introduce().

    internal class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public double Salary { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Teacher {Name} teaches {Subject}. The salary is {Salary}.");
        }
    }
}
