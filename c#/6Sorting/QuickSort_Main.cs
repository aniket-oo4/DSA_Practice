using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{
    internal class QuickSort_Main
    {

        /*
         * 1> Select pivot element
         * 2.> partition the array // partition as left side pivot is alwasys smaller than pivot , and right side is always greater 
         * 3.> Recursively sort the left and right subarray     
         * * 
         * 
         * 
         * */


        public static void Main(String[] args)
        {
            int[] nums = new int[] {8,3,2,7,9,6,4,5 };
            Console.WriteLine("Before sorting ::");
            foreach(var element in nums)
            {
                Console.Write(" " + element);
            }
            //QuickSort(ref nums, 0, nums.Length - 1);
            QuickSortArray(ref nums, 0, nums.Length - 1);
            Console.WriteLine("\nAfter \t \v sorting ::");
            foreach (var element in nums)
            {
                Console.Write(" " + element);
            }

        }
        public static void QuickSortArray(ref int[] arr, int low, int high)
        {
            //if (low >= high) return;  //{8,3,2,7,9,6,4,5 };
            if (low < high)
            {
                int partitionIndex = Partition(ref arr, low, high);
                QuickSortArray(ref arr, low, partitionIndex - 1);
                QuickSortArray(ref arr, partitionIndex + 1, high);
            }
        }
        public static int  Partition(ref int[] arr,int low,int high)
        {
            int i = low, j = high;
            int pivot = arr[low];
            while (i < j)
            {
                while(arr[i]<=pivot && i <= high-1)
                {
                    i++;
                }
                while (arr[j] > pivot && j >= low + 1) 
                {
                    j--;
                }
                //if (i > j) break;
                if (i < j) Swap(ref arr, i, j);
            }
            Swap(ref arr,low,j);
            return j;

        }

        public static void QuickSort(ref int[] arr, int low, int high)
        {
            if(low>=high) return ;
            if (low < high)
            {
                int partitionIndex = PivotArray(ref arr, low, high);
                QuickSort(ref arr, low,partitionIndex -1);
                QuickSort(ref arr, partitionIndex+1, high);
            }            
            //QuickSort(ref arr,low)
        }
        public static int PivotArray(ref int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int left = low;
            int right = high;
            while (left < right)
            {
                while (arr[left] <= pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left > right)
                {
                    break;
                }
                if (arr[left] > arr[right])
                {
                    Swap(ref arr, left, right);
                }
            }
            Swap(ref arr, low, right);
            return right;

        }

        public static void Swap(ref int[] arr,int left,int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
