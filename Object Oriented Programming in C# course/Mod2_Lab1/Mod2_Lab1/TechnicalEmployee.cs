using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {
        public int _successfulCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        public override string employeeStatus()
        {
            return toString() + " has " + _successfulCheckIns + " succesful check ins.";
        }
    }
}
