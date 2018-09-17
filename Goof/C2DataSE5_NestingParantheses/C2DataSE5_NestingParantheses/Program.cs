using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSE5_NestingParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "a(())b()";
            int aC = Parentheses(a);
            Console.WriteLine("ans is {0}", aC);

            String b = "(()1()";
            int bC = Parentheses(b);
            Console.WriteLine("ans is {0}", bC);

        }

        public static int Parentheses(string s)
        {
            // Approach: go through the string and 
            // if ( -> depth ++, 
            // if ) 0> depth --
            // if depth < 0 -> return maxdepth = 0; 
            // if depth at end > 0 -> return maxdepth = 0;
            int depth = 0;
            int maxdepth = 0;         
            foreach (char el in s) {
                if (el == '(')
                {
                    depth++;
                }
                else if (el == ')')
                {
                    depth--;
                }

                if (depth < 0) {
                    return 0; 
                }

                maxdepth = Math.Max(depth, maxdepth);

            }

            if (depth > 0)
            {
                return 0;
            }


            return maxdepth;
        }

    }
}
