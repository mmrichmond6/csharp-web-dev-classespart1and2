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

        public string Name { get; set; }
        private int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public string GradeLevel { get; set; }

        //Constructor (these have been "overloaded" meaning there is more than one constructor for the same type
        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            //Assign properties to values being passed through the constructor
            Name = name;
            StudentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
        //Another constructor
        public Student(string name, int sId)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of :  " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            //Update to appropriate fields: NumberOfCredits, Gpa
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = (double)(totalQualityScore / NumberOfCredits);
        }

        public string GetGradeLevel(int credits)
        {
            //Determine the grade Level of the student based on NumberOfCredits
            //Freshman (0-29 credits), Sophomore (30-59 credits), Junior (60-89 credits), or Senior (90+ credits)
            if (credits <= 29)
            {
                return "freshman";
            }
            else if (credits <= 59)
            {
                return "sophomore";
            }
            else if (credits <= 89)
            {
                return "junior";
            }
            else
            {
                return "senior";
            }
        }

    }
}
