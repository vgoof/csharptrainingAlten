using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 1, 1 };
            //int[] arr = { -3, 2, };
            //int[] arr = { -2, 4, -1, 6 };
            //int[] arr = { -2, -5, -6, -9 };
            //Console.WriteLine(Average(arr));

            //Console.WriteLine(Reversal("abcad"));
            //Console.WriteLine(Reversal("a0b c1d"));

            //Console.WriteLine(Ksmallest(new int[] { 2, 1, 4 }, 3));
            //Console.WriteLine(Ksmallest(new int[] { 7, 2, 1, 6, 1 }, 3));

            //Console.WriteLine(Difference(new int[] { 3, 2, 9, 5 }));
            //Console.WriteLine(Difference(new int[] { 1, 1, 1, 1, }));

            Console.WriteLine(Parentheses("a(())b()")); // 2
            Console.WriteLine(Parentheses("(()1()")); // 0
            Console.WriteLine(Parentheses("()")); //1
            Console.WriteLine(Parentheses("(((((((")); //0

            Console.ReadKey();

        }



        public static int Average(int[] a)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            double result = sum / a.Length;
            if (result % 2 != 0)
            {
                if (result > 0)
                    result++;
                else
                    result--;
            }
            return (int)Math.Round(result);
        }

        public static string Reversal(string s)
        {
            char[] charray = s.ToCharArray();
            char first = charray[0];
            char last = charray[charray.Length - 1];
            charray = charray.Reverse().ToArray();
            charray[0] = first;
            charray[charray.Length - 1] = last;
            return new string(charray);
        }

        public static int Ksmallest(int[] a, int k)
        {
            var distinct = a.Distinct().ToList().ToArray();
            Array.Sort(distinct);
            return distinct[k - 1];
        }

        public static int Difference(int[] a)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int num in a)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
            return Math.Abs(max - min);
        }

        public static int Parentheses(string s)
        {
            char[] charray = s.ToCharArray();

            int max = 0;
            int curr_max = 0;
            foreach (char ch in charray)
            {
                if (ch == '(')
                {
                    curr_max++;
                    if (curr_max > max)
                        max = curr_max;              
                } else if (ch == ')')
                {
                    if (curr_max > 0)
                        curr_max--;
                    else return 0;
                }
            }
            if (curr_max != 0)
                return 0;
            else return max;
        }
    }
}