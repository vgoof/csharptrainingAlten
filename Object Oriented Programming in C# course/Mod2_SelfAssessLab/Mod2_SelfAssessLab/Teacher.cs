using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessLab
{
    class Teacher : Person
    {
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
    }
}
