using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAsses
{
    class Student : Person
    {
        //private string m_name;
        private Course m_course;
        // public string Name { get => m_name; set => m_name = value; }

        // constructor
        public Student(string name, int age) : base(name, age) {
            studentCount++;
        }

        ~Student() {
            studentCount--;
        }

        public static int CountStudents() {
            return studentCount;
        }

        public static int studentCount = 0;

        internal Course Course { get => m_course; }

        public void takeTest() {

        }

        public void addCourse(Course newCourse) {
            m_course = newCourse;
        }

        public void whichCourse() {
            if (m_course != null)
            {
                string coursename = m_course.Name;
                Console.WriteLine(coursename);
            }
            else {            
                Console.WriteLine("student is not taking a course");
            }
        }
       

    }
}
