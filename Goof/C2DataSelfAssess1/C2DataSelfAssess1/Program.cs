using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSelfAssess1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Jo";
            Student[] studentArray = new Student[5];
            studentArray[0].Name = "Al";
            studentArray[1].Name = "Ba";
            studentArray[2].Name = "Co";
            studentArray[3].Name = "Da";
            studentArray[4].Name = "Ed";
            foreach (Student a in studentArray) {
                Console.WriteLine("This is (0)", a.Name);
                a.Study();
            }

            int grade = 5; 
            for(int i = 0; i < studentArray.Length; i++)
            {
                myTeacher.Grade();
                studentArray[i].Grade = grade;
                grade++;
            }

            foreach (Student a in studentArray)
            {
                Console.WriteLine("This is (0)", a.Grade);
            }
            



        }
    }

    struct Student {
        public String Name;
        public int Grade; 

        public void Study() {
            Console.WriteLine("Studying");
        }
    }

    struct Teacher
    {
        public String Name;

        public void Grade()
        {
            Console.WriteLine("Grading");
        }
    }
}
