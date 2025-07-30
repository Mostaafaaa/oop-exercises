using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MostafaOmar_oopExcercise
{
    internal class Student
    {
        // Exercise 2: Create a Student class with attributes name, age, and grade.
        // Add a method introduce() that prints the student details.
        string Name;
        int Age;
        string Grade;

        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void introduce()
        {
            Console.WriteLine("---- Student details ----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

    }
}
