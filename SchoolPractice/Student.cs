using System;
using System.Collections.Generic;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        
        //Properties
        private static int nextStudentId = 1;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double GPA { get; set; }

        //Constructor (these have been "overloaded" meaning there is more than one constructor for the same type
        public Student(string lastName, string firstName, int studentId, int numberOfCredits, double gpa)
        {
            //Assign properties to values being passed through the constructor
            this.LastName = lastName;
            this.FirstName = firstName;
            this.StudentId = studentId;
            this.NumberOfCredits = numberOfCredits;
            this.GPA = gpa;
        }
        //Another constructor
        public Student(string lastName, string firstName, int studentId) : this(lastName, firstName, studentId, 0, 0)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.StudentId = studentId;
            this.NumberOfCredits = 0;
            this.GPA = 0;
        }

        public Student(string lastName, string firstName) : this(lastName, firstName, nextStudentId)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            nextStudentId++;
        }
    }
}
