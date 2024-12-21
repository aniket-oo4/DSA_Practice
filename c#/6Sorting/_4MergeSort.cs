using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{
    internal class _4MergeSort
    {
        static int cnt = 0;
        public static void Main(String[] args)
        {
            int[] nums = new[] { 9, 4, 7, 6, 3, 1, 5 };
             
            foreach(var element in nums)
            {
                Console.Write(" " + element);
            }

            MergeSort(ref nums, 0, nums.Length - 1);
            Console.WriteLine("\n After sorting : ");
            
            foreach (var element in nums)
            {
                Console.Write (" " + element);
            }

        }


        public static void MergeSort(ref int[] arr, int low, int high)
        {
          
            
            if(low>=high)
            {
                return;
            }
            int mid = (low + high) / 2;
            MergeSort(ref arr, low, mid);
            MergeSort(ref arr,mid+1, high);
            cnt++;
            MergeArray(ref arr, low, mid, high);


        }

        public static void SwapArray(ref int[] arr ,int left ,int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
        // 1,3  2
        public static void MergeArray (ref int[] arr ,int low ,int mid  ,int high)
        {
            Console.Write($"Merge Called{cnt} ");
            List<int>temp =  new List<int>();
            int left = low;
            int right = mid + 1; 
            while(left<=mid && right<=high)
            {
                if (arr[left] < arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;

                }
            }
            while (left <= mid)
            {
                temp.Add(arr[left]);
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
            }


            for(int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }


        }
    }
}
