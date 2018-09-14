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
            //Bullet 1
            UProgram program = new UProgram("Information Technology");

            //Bullet 2
            Student s1 = new Student("John", "Doe", 25);
            Student s2 = new Student("Jane", "Doe", 23);
            Student s3 = new Student("Bob", "Ross", 21);

            //Bullet 3
            Course course = new Course("Programming with C#");

            //Bullet 4
            course.EnrollStudent(s1);
            course.EnrollStudent(s2);
            course.EnrollStudent(s3);

            //Bullet 5
            Teacher t1 = new Teacher("Dennis", "Ritchie", 70);

            //Bullet 6
            course.AddTeacher(t1);

            //Bullet 7
            Degree degree = new Degree("Bachelor");

            //Bullet 8
            degree.AddCourse(course);

            //Bullet 9
            //Create the same UProgram object? Skipping and using the UProgram object from bullet 1.

            //Bullet 10
            program.Degree = degree;

            //Bullet 11
            Console.WriteLine($"The name of the program is {program.Name} and contains a {program.Degree.Name} degree.");
            Console.Write("The name(s) of the course(s) in the degree is/are ");
            program.Degree.GetCourseNames().ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine($"\nThe amount of students in the course is {program.Degree.Courses.First().EnrolledStudents.Count}");

            Student s9 = new Student("", "", 1);
            Person aa = s9;
        }
    }
}
