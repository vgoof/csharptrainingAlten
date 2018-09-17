using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSA4_MaxDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 2, 3, 5 };
            int aR = Difference(a);
            Console.WriteLine("ans is {0}", aR);

            int[] b = { 1, 1, 1, 1 };
            int bR = Difference(b);
            Console.WriteLine("ans is {0}", bR);

        }


        public static int Difference(int[] a)
        {
            int maxdiff = 0;

            for(int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    maxdiff = Math.Max(Math.Abs(a[i] - a[j]), maxdiff);
                }
            }
            return maxdiff;

        }

     
    }
}
