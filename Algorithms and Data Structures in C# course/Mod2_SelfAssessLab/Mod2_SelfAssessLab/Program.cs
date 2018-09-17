using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0].Name = "John";
            students[0].LastName = "Doe";

            for(int i = 0; i < students.Length; i++)
            {
                students[i].Name = "John";
                students[i].LastName = "Doe";
            }

            Console.WriteLine($"the first student's name is {students[0].Name} {students[0].LastName}.");
            Console.WriteLine($"the second student's name is {students[1].Name} {students[1].LastName}.");
            Console.WriteLine($"the third student's name is {students[2].Name} {students[2].LastName}.");
        }

        struct Student
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            public void Study()
            {
                Console.WriteLine("Student is studying...");
            }

        }

        struct Teacher
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            public void GradeAssignment()
            {
                Console.WriteLine("Teacher is grading assignment...");
            }

        }
    }
}
