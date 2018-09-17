using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod4_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");

           


            List<Student> students = new List<Student>();
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);


            Random random = new Random();

            foreach (Student s in students)
            {
                for(int i = 0 ; i < 5; i++)
                {
                    s.grades.Add(random.Next(1, 10));
                }
            }

            foreach(Student s in students)
            {
                Console.WriteLine($"This student's name is {s.FirstName} {s.LastName}.");
                //s.grades.Pop();
                //s.grades.Push(10);
                Console.WriteLine($"These are his/her grades : {string.Join(", ", s.grades)}.");
                
            }

        }
    }
}
