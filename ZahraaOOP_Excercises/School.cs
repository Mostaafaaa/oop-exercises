using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    // Exercise 13: Create a School class that stores a list of Student objects.
    // Add methods add_student(student) and show_all_students().

    internal class School
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowAllStudents()
        {
            foreach (var student in students)
            {
                student.Introduce(); // From the Student class
            }
        }
    }
}
