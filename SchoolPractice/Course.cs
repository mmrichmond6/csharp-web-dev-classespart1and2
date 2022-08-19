using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private string Topic;
        private Teacher Instructor;
        private List<Student> EnrolledStudents;

        public Course(string topic, Teacher instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            EnrolledStudents = enrolledStudents;
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }
    }
}
