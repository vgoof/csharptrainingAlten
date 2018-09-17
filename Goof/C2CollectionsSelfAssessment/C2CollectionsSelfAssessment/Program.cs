using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace C2CollectionsSelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ad", "Zo");
            Student s2 = new Student("Bo", "Ya");
            Student s3 = new Student("Co", "Xi");

            s1.AddGrade(5);
            s1.AddGrade(6);
            s1.AddGrade(7);
            s1.AddGrade(3);
            s1.AddGrade(10);

            s2.AddGrade(3);
            s2.AddGrade(9);
            s2.AddGrade(8);
            s2.AddGrade(2);
            s2.AddGrade(9);

            s3.AddGrade(3);
            s3.AddGrade(4);
            s3.AddGrade(2);
            s3.AddGrade(10);
            s3.AddGrade(10);

            ArrayList myList = new ArrayList( );
            myList.Add(s1);
            myList.Add(s2);
            myList.Add(s3);
            
        
            foreach (Student si in myList) {
                Console.WriteLine("Student with firstname {0} and lastname {1}", si.Firstname, si.Lastname);
            }



        }
    }
}
