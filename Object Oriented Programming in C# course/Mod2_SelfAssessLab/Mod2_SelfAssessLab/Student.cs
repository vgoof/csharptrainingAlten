using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessLab
{
    class Student : Person
    {
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
    }
}
