using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Mod1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // list to sort
            int[] numbersOriginal = { 1, 5, 2, 3, 7, 4, 10, 15, 25, 6 };
            //int[] numbersOriginal = { 5, 4, 3, 2, 1 };
            int[] numbers = new int[numbersOriginal.Length];
            numbersOriginal.CopyTo(numbers,0);            
            
            writeArrayToConsol(numbers);

            // algorithm to sort the numbers
            Console.WriteLine("bubble algo starting");
            int icountBubble = 0;
            bool swapDone = false;
            while (!swapDone) {
                swapDone = true;
                for (uint i = 0; i < numbers.Length -1; i++) {
                    icountBubble++;
                    // check in next element (if existing is larger 
                    if (numbers[i + 1] < numbers[i]) {
                        int tempNum = numbers[i];                        
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = tempNum;
                        swapDone = false;
                        writeArrayToConsol(numbers);                        
                    }                    
                }                
            }

            Console.WriteLine("bubble done, result is ");
            writeArrayToConsol(numbers);
            Console.WriteLine("bubble done, it took {0} operations ", icountBubble);
            // algorithm to sort by intersection
            Console.WriteLine("intersection algo");
            int[] numArr2 = new int[numbersOriginal.Length];            
            numbersOriginal.CopyTo(numArr2, 0);
            writeArrayToConsol(numArr2);
            int icountInter = 0;
            Console.WriteLine("intersection algo starting");
            // start at element 2 (i=1)
            for (int i = 1; i < numArr2.Length; i++)
            {
                //Console.WriteLine("indx i is {0}", i);
                int val = numArr2[i];
                // check preceding values to find first value in array less than the one in element i. inject it there
                for (int j = i-1; j >= 0; j--)
                {
                    icountInter++;
                    //Console.WriteLine("indx i is {0}, j is {1}", i, j);
                    if (numArr2[j] > val)
                    {
                        numArr2[j + 1] = numArr2[j];
                        numArr2[j] = val;
                        
                    }
                    else {
                        // stop if you are not higher than preceding
                        break;
                    }
                }
                writeArrayToConsol(numArr2);
            }
            Console.WriteLine("Inter done, result is ");
            writeArrayToConsol(numArr2);
            Console.WriteLine("Inter done, it took {0} operations ", icountInter);



        }

        private static void writeArrayToConsol(int[] num)
        {
            string output = "";
            foreach (int el in num) {
                output += el + " ";
            }
            Console.WriteLine(output);

        }



    }
}

