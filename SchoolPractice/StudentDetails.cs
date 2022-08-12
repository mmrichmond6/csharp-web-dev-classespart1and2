using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class StudentDetails
    {
        Student student = new Student("Pavel", "Smith");
        Student student2 = new Student("Thomas", "Richmond", 123, 4, 4);

        public void Print()
        {
            Console.WriteLine("{1} {0}'s student ID is {2} and has {3} credits with a GPA of {4}.", student.FirstName, student.LastName, student.StudentId, student.NumberOfCredits, student.GPA);
            Console.WriteLine("{1} {0}'s student ID is {2} and has {3} credits with a GPA of {4}.", student2.FirstName, student2.LastName, student2.StudentId, student2.NumberOfCredits, student2.GPA);
        }
    }
}
