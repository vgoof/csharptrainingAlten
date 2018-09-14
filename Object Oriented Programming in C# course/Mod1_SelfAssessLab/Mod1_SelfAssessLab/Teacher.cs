using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessLab
{
    class Teacher
    {
        public Teacher(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            _amountOfTeachers++;

        }

        private string Name { get; }
        private string LastName { get; }
        private int Age { get; }

        private static int _amountOfTeachers = 0;

        public static int getAmountOfTeachers()
        {
            return _amountOfTeachers;
        }
    }
}
