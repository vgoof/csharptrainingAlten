using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessLab
{
    class Student
    {
        public Student(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            _amountOfStudents++;
            
        }

        private string Name { get; }
        private string LastName { get; }
        private int Age { get; }

        private static int _amountOfStudents = 0;

        public static int getAmountOfStudents()
        {
            return _amountOfStudents;
        }
    }
}
