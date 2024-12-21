using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{
    internal class SelectionSort //o(n^)
    {
        /*
         * algorithm motive  : select minimum and swap 
         * Selection sort is an algorithm which selects the key and compare it with another values till end and swap the keyvalue if the compared value is smaller than key 
         * 
         * for i =0 ;i<=Length-2;i++;  <--  this loop goes till  last index -1 cause the array will be sorted there 
         *      for j =i+1 ;j<=Length-1 ;j++   <-- this loop  goes till last index of first loop till end 
         *          if nums[i]> nums[j] : swap(nums[i],nums[j]);
         * 
         * or
         *  for i =0 ;i<=Length-2;i++;  
         *  int mini=i;
         *      for j =i+1 ;j<=Length-1 ;j++  
         *          if nums[mini]> nums[j] : mini=j;
         *      temp=nums[i] ;
         *      nums[i]=nums[mini];
         *      nums[mini]=temp;
         * 
         * 
         * Algorithm :
         *  firs loop executes till n hence  for first --> o(n)
         *  second loop executes such as 
         *      n-1 + n-2+ n-3 + n-4 + n-5 so on 
         *   by applying formula of sum of first natural n *(n+1)/2== n^2 /2 +n/2 ==n^ +n 
         *   final time complexity cause  we ignore smaller things(n/2)  and constant  (/2) --> n^2 
         *   
         *   Best   -->O(n^2)
         *   Average-->O(n^2)
         *   Worst  -->O(n^2)
         * 
         * */

        public static void Main(String[] args)
        {
            int[] nums = new[] { 3, 12, 4, 2, 52, 2, 65, 77 };

            Console.WriteLine("Array Before  Sorting ::");
            foreach (int element in nums)
            {
                Console.Write(" " + element + " ");
            }
            Console.WriteLine("Array after Sorting ::");
            funcSelectionSort(ref nums);
            foreach (int element in nums)
            {
                Console.Write(" " + element + " ");
            }
        }
        public static void SwapArrayValues(ref int  [] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static  void funcSelectionSort(ref int[] nums) // O(n^2)
        {
            for(int i=0; i <= nums.Length - 2; i++)  
            {
                int mini=i;
                for(int j = i + 1; j <= nums.Length - 1; j++)
                {
                    // if (nums[i] > nums[j])
                    // {
                    //     SwapArrayValues(ref nums, i, j);
                    // }
                    if(nums[mini]>nums[j]){
                        mini=j;
                    }
                }
                SwapArrayValues(ref nums,i,mini);
            }

            /*
             * 
             *by selecting maximum and sort 
             *for (int n=nums.Length-1;n>0; n--) //o(n)
            {
                for(int j = n - 1; j >= 0; j--) //O(n-1)
                {
                    if (nums[j] > nums[n])
                    {
                        Swap(ref nums, j, n);
                    }
                }
            }
             * 
             * 
             * */


        }

    }
}
