﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 10, 3, 2, 4 };
            Console.WriteLine("Before: " + string.Join(", ", nums));
            nums = BubbleSort(nums);
            Console.WriteLine("After: " + string.Join(", ", nums));
        }

        public static int[] BubbleSort(int[] nums)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < nums.Length - 1 ; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return nums;
        }

    }
}
