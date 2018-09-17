using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Generics_Selfassessment
{
    class StudentStack
    {
        private Stack<int> m_grades = new Stack<int>();

        public StudentStack(string first, string last, int age, string prog)
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
        public Stack<int> Grades { get => m_grades; }
        public void AddGrade(int grade) { m_grades.Push(grade); }

        public void ChangeGrade(int index, int grade)
        {
            int nCount = Grades.Count;
            if (index < nCount)
            {
                Stack<int> tempStack = new Stack<int>();
                for (int i = 0; i < nCount; i++)
                {
                    int tGrade = Grades.Pop();
                    if (i == index)
                    {
                        tempStack.Push(grade);
                    }
                    else
                    {
                        tempStack.Push(tGrade);
                    }
                }
                for (int i = 0; i < nCount; i++)
                {
                    int tG = tempStack.Pop();
                    Grades.Push(tG);
                }


            }

        }
    }
}
