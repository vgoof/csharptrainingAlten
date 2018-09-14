using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAsses
{
    class Program
    {
        static void Main(string[] args)
        {
            // String filename = "SchoolInfo.txt";

            var myProgram = new UProgram("Information Technology");
            var student1 = new Student("Jan", 20);
            var student2 = new Student("Piet", 21);
            var student3 = new Student("Henk", 19);
            var teacher1 = new Teacher("Anne", 34);
            var teacher2 = new Teacher("Maria", 45);


            var course1 = new Course("Programming with C#");
            course1.addStudent(student1);
            course1.addStudent(student2);
            course1.addStudent(student3);
            course1.Teacher = teacher1;
            course1.teachers[0] = teacher1;
            var degree1 = new Degree("Bachelor");
            degree1.addCourse(course1);

            myProgram.addDegree(degree1);
            
            student1.writeInfo();
            teacher1.writeInfo();

            student1.whichCourse();



            Console.WriteLine($"Program {myProgram.Name} contains the degree {myProgram.getDegree(0).Name}");
            Console.WriteLine($"The degree {myProgram.getDegree(0).Name} contains the course {myProgram.getDegree(0).getCourse(0).Name}");
            Console.WriteLine($"The course {myProgram.getDegree(0).getCourse(0).Name} contains {myProgram.getDegree(0).getCourse(0).getStudentCount()} students");
        }
    }
}
