using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessLab
{
    class Teacher : Person
    {

        private List<Course> _teachingCourses = new List<Course>();

        public Teacher(string name, string lastName, int age) : base(name, lastName, age)
        {
            _amountOfTeachers++;
        }
        private static int _amountOfTeachers = 0;

        public static int getAmountOfTeachers()
        {
            return _amountOfTeachers;
        }

        public void GradeTest()
        {
            Console.WriteLine("Graded test!");
        }

        public void TeachCourse(Course c)
        {
            _teachingCourses.Add(c);
        }

        public void WriteRelevantInfo()
        {
            List<string> strings = new List<string>();

            strings.Add("Name : " + _firstName + " " + _lastName);
            strings.Add("Age : " + _age);
            strings.Add("Teaching courses:");

            foreach(Course c in _teachingCourses)
            {
                strings.Add(c.Name);
            }

            WriteRelevantInfo(strings, "Teacher " + _firstName + _lastName + ".txt");
        }

    }
}
