using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessLab
{
    class Course
    {
        public Course(string name)
        {
            Name = name;
            
        }

        public string Name { get; }
        public List<Student> EnrolledStudents { get; } = new List<Student>();
        private List<Teacher> Teachers { get; } = new List<Teacher>();

        public void EnrollStudent(Student s)
        {
            EnrolledStudents.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t);
        }
    }
}
