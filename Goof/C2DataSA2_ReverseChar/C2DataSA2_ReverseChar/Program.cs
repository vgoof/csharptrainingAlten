using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSA2_ReverseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "abcad";
            String s1R = Reversal(s1);
            Console.WriteLine(s1R);

            String s2 = "a0b c1d";
            String s2R = Reversal(s2);
            Console.WriteLine(s2R);




        }


        public static string Reversal(string s)
        {
            
            String s0 = s.Substring(0, 1);
            String se = s.Substring(s.Length-1, 1);
            String sOut = s0;

            for (int i = s.Length - 2; i > 0; i--)
            {
                sOut += s.Substring(i, 1);
            }
            sOut += se; 
            return sOut;
        }

    }
}
