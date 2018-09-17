using System;
using System.Collections;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();

            Student s1 = new Student("John", "Doe");
            Student s2 = new Student("Jane", "Doe");
            Student s3 = new Student("BoJack", "Horseman");
            s1.GradeStack.Push(6);
            s1.GradeStack.Push(7);
            s1.GradeStack.Push(8);
            s1.GradeStack.Push(5);
            s1.GradeStack.Push(9);

            s2.GradeStack.Push(6);
            s2.GradeStack.Push(7);
            s2.GradeStack.Push(8);
            s2.GradeStack.Push(5);
            s2.GradeStack.Push(9);

            s3.GradeStack.Push(6);
            s3.GradeStack.Push(7);
            s3.GradeStack.Push(8);
            s3.GradeStack.Push(5);
            s3.GradeStack.Push(9);

            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);

            foreach(Student s in studentList)
            {
                Console.WriteLine($"The student is called {s.Name} {s.LastName}");
            }
            
        }
    }
}
