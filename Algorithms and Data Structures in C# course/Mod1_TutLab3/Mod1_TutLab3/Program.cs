using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_TutLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[2]);

            int forEachTotal = 0;
            foreach(int num in numbers)
            {
                forEachTotal += num;
            }

            Console.WriteLine(forEachTotal);
        }
    }
}
