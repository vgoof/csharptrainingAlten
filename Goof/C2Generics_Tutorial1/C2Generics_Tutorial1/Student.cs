using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Generics_Tutorial1
{
    class Student
    {
        public Student(string first, string last, int age, string prog)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Program = prog;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }

    }
}
