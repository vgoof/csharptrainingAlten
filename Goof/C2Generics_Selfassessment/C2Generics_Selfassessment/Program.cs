using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace C2Generics_Selfassessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");
            stud1.AddGrade(5);
            stud1.AddGrade(6);
            stud1.AddGrade(7);
            stud1.AddGrade(8);
            stud1.AddGrade(9);

            stud2.AddGrade(10);
            stud2.AddGrade(7);
            stud2.AddGrade(8);
            stud2.AddGrade(9);
            stud2.AddGrade(3);

            stud3.AddGrade(1);
            stud3.AddGrade(10);
            stud3.AddGrade(8);
            stud3.AddGrade(3);
            stud3.AddGrade(4);

            List<Student> students = new List<Student>();
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);

            foreach (Student si in students)
            {
                string grades = GradesToString(si.Grades);
                Console.WriteLine("Student firstname: {0}, lastname: {1}, grades: {2}", si.FirstName, si.LastName, grades);
            }

            // change grade
            // stud1.ChangeGrade(4, 6);            

            foreach (Student si in students)
            {
                string grades = GradesToString(si.Grades);
                Console.WriteLine("Student firstname: {0}, lastname: {1}, grades: {2}", si.FirstName, si.LastName, grades );
            }
        }

        private static string GradesToString(SortedSet<int> grades)
        {
            string sOut = "";
            foreach (int grade in grades) {
                sOut += grade +  " ";
            }
            return sOut;
        }

    }
}
