using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student studentRichmond = new Student("Michele", 12345, 1, 4.0);

            Console.WriteLine(studentRichmond.Name + "  " + studentRichmond.StudentId + "  " + studentRichmond.NumberOfCredits + "  " + studentRichmond.Gpa);

            studentRichmond.Print();


        }
    }
}
