using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 2: Create a Student class with attributes name, age, and grade. 
     * Add a method introduce() that prints the student details.*/
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void Introduce()
        {
            Console.WriteLine($"{Name}'s age is: {Age} years old and the grade : {Grade}.");
        }
    }
}
