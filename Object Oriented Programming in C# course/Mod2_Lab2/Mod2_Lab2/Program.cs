using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new TechnicalEmployee("Libby");
            Employee e2 = new TechnicalEmployee("Zaynah");
            Employee e3 = new BusinessEmployee("Winter");

            Console.WriteLine(e1.employeeStatus());
            Console.WriteLine(e2.employeeStatus());
            Console.WriteLine(e3.employeeStatus());
        }
    }
}
