using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSelfAssess2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2 };
            int b = Average(a);
            Console.WriteLine("Average is {0}", b);

            int[] c = { -1, -2 };
            int d = Average(c);
            Console.WriteLine("Average is {0}", d);


            int[] e = { -2, 4, -1, 6};
            int f = Average(e);
            Console.WriteLine("Average is {0}", f);

        }

        public static int Average(int[] a)
        {
            // Initialize
            int average = 0;
            // Compute sum of integers
            int sum = 0;            
            foreach (int el in a) {
                sum += el;
            }
            // Compute non-rounded average
            double n = (double)a.Length;
            double ave = (double)sum / n;
            double absave = Math.Abs(ave);
            // rget remainder after divison by 1
            double rem = ave % 1;
            double absrem = Math.Abs(rem);
            // round to below (also when this is a negative number)
            int lowerInt = (int)(ave - absrem );
            int lowerIntAbs = (int)Math.Abs(ave - absrem);
            if (ave % 2 <= 0.5 && absrem <= 0.5) {
                // go down
                average = lowerIntAbs;
            }
            else if (ave % 2 <= 0.5 && absrem > 0.5) {
                // go iup
                average = lowerIntAbs + 1;
            }
            else if (ave % 2 > 0.5 && absrem < 0.5)
            {
                // go down
                average = lowerIntAbs;
            }
            else
            {
                // go iup
                average = lowerIntAbs + 1;
            }

            // set minus back
            if (ave < 0) {
                average *= -1;
            }

            // return
            return average;
        }
    }
}
