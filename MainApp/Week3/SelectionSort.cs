using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class SelectionSort
    {
        public static void selectionSorting()


        {
            int[] nums = { 2, 1, 16, 4, 3, 0 };
            

            for(int i = 0; i < nums.Length - 1; i++)
            {
                // Setting the value of minimun index to value of i i.e. 0 initially.
                var min_index = i;

                for(int j = i+1; j < nums.Length; j++)
                {
                    var temp = 0;

                    if (nums[j] < nums[i])
                    {
                        min_index = j;
                    }

                    temp = nums[i];
                    nums[i] = nums[min_index];
                    nums[min_index] = temp;
                }
            }
            
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
