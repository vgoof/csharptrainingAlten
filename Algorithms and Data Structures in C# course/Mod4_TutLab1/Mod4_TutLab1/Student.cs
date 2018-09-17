using System;
using System.Collections.Generic;
using System.Text;

namespace Mod4_TutLab1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }

        public Student(string fn, string ln, int age, string prog)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
            Program = prog;
        }
    }
}
