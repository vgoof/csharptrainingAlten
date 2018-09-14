﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAsses
{
    class Course : IDisposable
    {
        private string m_name;
        private List<Student> m_studentList = new List<Student>();
        private Teacher m_Teacher;
        //private List<Teacher> m_teacherList = new List<Teacher>();
        private int m_studentCount = 0;
        public Teacher[] teachers = new Teacher[10];

        public string Name { get => m_name; set => m_name = value; }

        public Teacher Teacher { get => m_Teacher; set => m_Teacher = value; }
        //public List<Teacher> TeacherList { get => m_teacherList; set => m_teacherList = value; }

       

        public Course(string name)
        {
            this.Name = name;
          
        }

        public void addStudent(Student newStudent) {
            m_studentList.Add(newStudent);
            newStudent.addCourse(this);
            m_studentCount++;
        }
           

        public int getStudentCount()
        {
            return m_studentCount;
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

