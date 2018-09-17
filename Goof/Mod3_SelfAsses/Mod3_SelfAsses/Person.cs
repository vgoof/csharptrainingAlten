using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod3_SelfAsses
{
    abstract class Person
    {
        private string m_name;
        private int m_age;

        public Person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }

        //~Person() {
        //    Dispose();
        //}

        public string Name
        {
            get => m_name;
        }
        public int Age
        {
            get => m_age;

        }

        public void WriteInfo()
        {
            string filename = this.Name + ".txt";
            WriteInfo(filename, Name);
        }


        public void WriteInfo(string filename, string text)
        {
            using (var sr = new StreamWriter(filename))
            { // Assigns "streamReaderObject" to read from a text file named "file1" sr.WriteLine(text); } 
                sr.WriteLine(m_name);
            }
        }
    }
}
