using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAsses
{
    class UProgram
    {
        private string m_Name;
        private List<Degree> m_degreeList = new List<Degree>();

        public string Name { get => m_Name; set => m_Name = value; }

        public UProgram(string name) {
            this.m_Name = name;
        }

        public void addDegree(Degree newDegree) {
            m_degreeList.Add(newDegree);
        }

        public Degree getDegree(int indx) {
            return m_degreeList[indx];
        }
    }
}
