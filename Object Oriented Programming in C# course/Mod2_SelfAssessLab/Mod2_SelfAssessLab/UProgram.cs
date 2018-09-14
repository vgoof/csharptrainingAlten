using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessLab
{
    class UProgram
    {
        public UProgram(string name)
        {
            Name = name;
            //Degree = degree;
        }
        public string Name { get; }
        public Degree Degree { get; set; }
 
    }
}
