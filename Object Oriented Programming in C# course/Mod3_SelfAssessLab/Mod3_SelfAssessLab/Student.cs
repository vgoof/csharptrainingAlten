using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessLab
{
    class Student : Person
    {

        private List<Course> _takingCourses = new List<Course>();
        public Student(string name, string lastName, int age) : base(name, lastName, age)
        {   
            _amountOfStudents++;  
        }

        private static int _amountOfStudents = 0;

        public static int getAmountOfStudents()
        {
            return _amountOfStudents;
        }

        public void TakeTest()
        {
            Console.WriteLine("Taken test!");
        }

        public void TakeCourse(Course c)
        {
            _takingCourses.Add(c);
        }

        public void WriteRelevantInfo()
        {
            List<string> strings = new List<string>();

            strings.Add("Name : " + _firstName + " " + _lastName);
            strings.Add("Age : " + _age);
            strings.Add("Taking courses:");

            foreach (Course c in _takingCourses)
            {
                strings.Add(c.Name);
            }

            WriteRelevantInfo(strings, "Student " + _firstName + _lastName + ".txt");
            
        }


    }
}
