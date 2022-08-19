using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(string topic, Teacher instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            EnrolledStudents = enrolledStudents;
        }
        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return Instructor + " (Course topic: " + Topic + ", Students Enrolled: " + EnrolledStudents + ")";
        }


        //public override bool Equals(object obj)
        //{
            //return obj is Course course &&
                   //Topic == course.Topic &&
                   //EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        //}

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }
            //return obj is Course course &&  Topic == course.Topic &&
            //EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
            Course courseObj = obj as Course;
            return Instructor == courseObj.Instructor && Topic == courseObj.Topic;
        }

    }
}
