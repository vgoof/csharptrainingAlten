using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mod3_Lab1
{
    class Student
    {
        public string Name { get; }
        public string LastName { get; }
        public Stack GradeStack { get => gradeStack; set => gradeStack = value; }

        private Stack gradeStack = new Stack();

        public Student(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
    }
}
