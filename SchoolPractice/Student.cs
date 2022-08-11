using System;
using System.Collections.Generic;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId) : this(name, studentId, 0, 0) { }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void Print()
        {
            Console.WriteLine(Name + "  " + StudentId + "  " + NumberOfCredits + "  " + Gpa);
        }


        /*
         public List<Student> students = new List<Student>()
         {
             new Student ("student1", 1),
             new Student ("student2", 2),
             new Student ("student3", 3)
         };

         public List<string> GetList(List<string> students)
         {
             return students;
         }

         public void PrintList()
         {
             foreach(var student in students)
             {
                 Console.WriteLine(student);
             }
         }
        */
    }
}
