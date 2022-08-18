using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student sally = new Student("Fields", "Sally");
            Student sally2 = new Student("Fields", "Sally2");
            //instantiate the object studentdetails and within it we will have instantiated the student class as well; now we have access to the print output by calling the method
            StudentDetails sd = new StudentDetails();
            sd.Print();
            Console.WriteLine("The Student class works! " + sally2.StudentId + " is a student!");

            Teacher scott = new Teacher("Scott", "Kuhl", "C#", 5);
            Console.WriteLine("The Teacher class works!  " + scott.FirstName + " is a teacher!");


        }
    }
}
