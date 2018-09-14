using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessLab
{
    abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }

        public Person(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }
    }
}
