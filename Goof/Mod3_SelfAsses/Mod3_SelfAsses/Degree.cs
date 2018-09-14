using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAsses
{
   class Degree
    {
        private string m_name;
        private List<Course> m_courseList =  new List<Course>();
        public string Name { get => m_name; set => m_name = value; }

        public Degree(string name) {
            this.Name = name;
        }

        public void addCourse(Course newCourse)
        {
            m_courseList.Add(newCourse);
        }

        public Course getCourse(int indx)
        {
            return m_courseList[indx];
        }
       
       

    }
}
