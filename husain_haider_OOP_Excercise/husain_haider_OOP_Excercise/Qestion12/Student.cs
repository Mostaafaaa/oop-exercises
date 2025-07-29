using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion2
{
    
            /*Exercise 2: Create a Student class with attributes name, age, and grade. 
             * Add a method introduce() that prints the student details.

*/


    internal class Student
    {
        string name { get; set; }
        string age { get; set; }
        string grade {  get; set; }

        private static List<Student> studentsList = new List<Student>();
        
        public Student(string aName , string aAge,string aGrade) 
        {
            name = aName;
            age = aAge;
            grade = aGrade;
            studentsList.Add(this);
        }


        public void introduce()
        {
            foreach (Student student in studentsList)
            {
                Console.WriteLine($"Student name is: {student.name} \t-\t Age:{student.age} \t-\t Grade:{student.grade}");
            }
            
        }


    }
}
