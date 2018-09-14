using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_CylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The volume of a cylinder with base 3 and height 5 is {0}", CalculateVolumeCylinder(3, 5));
        }

        static double CalculateVolumeCylinder(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}
