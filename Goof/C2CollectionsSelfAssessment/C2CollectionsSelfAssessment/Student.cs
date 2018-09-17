using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C2CollectionsSelfAssessment
{
    class Student
    {
        private string m_firstName;
        private string m_lastName;
        private Stack<int> m_grades = new Stack<int>();

        public Student(string firstName, string lastName) {
            m_firstName = firstName;
            m_lastName = lastName;
        }

        public string Firstname { get => m_firstName;}
        public string Lastname { get => m_lastName; }

        public Stack<int> Grades { get => m_grades; }

        public void AddGrade(int grade) {
            m_grades.Push(grade);
        }

    }
}
