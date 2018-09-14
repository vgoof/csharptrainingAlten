using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessLab
{
    class Degree
    {

        public Degree(string name)
        {
            Name = name;
        }

        public string Name { get;}
        public List<Course> Courses { get; } = new List<Course>();

        public void AddCourse(Course c)
        {
            Courses.Add(c);
        }

        public List<string> GetCourseNames()
        {
            List<string> l = new List<string>();
            foreach(Course c in Courses)
            {
                l.Add(c.Name);
            }
            return l;
        }
    }
}
