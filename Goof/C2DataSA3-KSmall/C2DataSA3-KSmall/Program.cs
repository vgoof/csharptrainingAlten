using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataSA3_KSmall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 1, 4 };
            int ans1 = Ksmallest(arr1, 3);
            Console.WriteLine(" ans is {0}", ans1);

            int[] arr2 = {7, 2, 1, 6, 1};
            int ans2 = Ksmallest(arr2, 3);
            Console.WriteLine(" ans is {0}", ans2);

        }



        public static int Ksmallest(int[] a, int k)
        {
            // finds k'th smallest of the unique array
            // for: [7, 2, 1, 6, 1], k = 3 -> 6 (1, 2, 6)
            int ans = 0;
            List<int> b = new List<int>();
            foreach (int aEl in a)
            {
                b.Add(aEl);
            }
            b.Sort();
            var c = b.Distinct().ToList();
            ans = c[k - 1];
            return ans;
        }

    }    
}
