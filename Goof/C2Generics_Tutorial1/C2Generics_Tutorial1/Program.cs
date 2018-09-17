using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C2Generics_Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);
            foreach (Student stud in students)
            {
                Console.WriteLine(stud.FirstName);
            }

            bool exists = students.Contains<Student>(stud1);
            Console.WriteLine(exists.ToString());
            students.Remove(stud3);
            Console.WriteLine(students.Count());
            bool exists2 = students.Contains<Student>(stud2);
            Console.WriteLine(exists2.ToString());

        }
    }
}
