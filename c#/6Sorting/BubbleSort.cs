using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{
    internal class BubbleSort
    { // Select Maximum and then swap  start from end 
        // Bubble Sort is nothing but the selecting the maximum element and placing it to the end of the list 
        //Bubble Sort Compares the Adjacent Values  [which are side by side ] arr[j] ,arr[j+1] 
        /* for(i=length-1;i>=0;i--)
         *      for( j=0;j<i-1;j++)
         *          if(arr[j])> arr[j+1];
         *              swapt(arr[j],arr[j+1]);
         * 
         * Complexities 
         *  Worst Case  : o(n^2);
         * Average Case  : o(n^2);
         *  best Case    : O(n) ; optimize the solution  for  the input which is already sorted then why you need to  perform checking operations 
         */

        public static void Main(String[] args)
        {
            int[] nums = new[] { 3, 2, 4, 556, 23, 1, 23, 4, 6636, 3, 22, 5, 23, 6667, 73, 2, 8, 555 };
            Console.WriteLine(  "Before Bubble  Sort");
            foreach(var element in nums)
            {
                Console.Write(" " + element + " ");
            }
            Console.WriteLine(" \nAfter Bubble Sort ");
            funcBubbleSort(ref nums);
            foreach(var element in nums)
            {
                Console.Write(" " + element + " ");
            }
        }

        public static void Swap(ref int[] arr,int  j,int n)
        {
            int temp = arr[j];
            arr[j] = arr[n];
            arr[n] = temp;
        }
        public static void funcBubbleSort(ref int[] nums) // Worst Case will be O(n^2) similar as selection sort calculate by using sum firs n natural numbers 
        {
            //for (int n=nums.Length-1;n>0; n--) //o(n)
            // {
            //     for(int j = 0; j <=n-1; j++) //O(n-1)
            //     {
            //         if (nums[j] > nums[j+1])
            //         {
            //             Swap(ref nums, j, j+1);
            //         }
            //     }
            // }

            /*Optimized solution for best case o(n);  // check by providing sorted input
             */
            for (int n = nums.Length - 1; n > 0; n--) //o(n) 
            {
                int didSwap = 0;
                for (int j = 0; j <= n - 1; j++) 
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(ref nums, j, j + 1);
                        didSwap = 1;
                    }
                }
                if (didSwap == 0) { break; }
                Console.WriteLine(  "Check for how many times loop executed \n");
            }


        }

    }
}
