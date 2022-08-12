namespace SchoolPractice
{
    public class Teacher
    {
        private string FirstName;
        private string LastName;
        private string Subject;
        private int YearsTeaching;

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }   
    }
}