using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{
    internal class AllSorts
    {
        public static void Swap(ref int[] arr, int i, int j)
        {
            int temp = arr[i]; arr[i] = arr[j];
            arr[j] = temp;
        }
        public static void ShowArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(" " + element);
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 34, 2, 34, 4323, 45, 323, 21, 34, 54252, 66, 23, 332, 545, 53, 4, 9, 0 };
            Console.WriteLine("Array before sorting ::");
            ShowArray(arr);
            //Array.Sort(arr,(a,b)=>(b.CompareTo(a))); //reverse sorting second parameter is  the delegate which is used to compare the elements it inherently uses the quick sort
            //Array.Sort<int>(arr, (a, b) => (a.CompareTo(b))); //normal sorting
            //QuickSort(ref arr, 0,arr.Length-1);
            //MergeSort(ref arr, 0, arr.Length - 1);
            BubbleSort(ref arr);
            //Array.Sort(arr);

            Console.WriteLine("\nArray After sorting ::");
            ShowArray(arr);

        }



        #region MergeSort
        public static void MergeSort(ref int[] arr, int low, int high) //time complexity is O(nlogn) and space complexity is O(n)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(ref arr, low, mid);
                MergeSort(ref arr, mid + 1, high);
                Merge(ref arr, low, mid, high); 
            }
        }
        public static void Merge(ref int[] arr, int low, int mid, int high)//time complexity is O(n) and space complexity is O(n)
        {
            int left = low, right = mid + 1;
            List<int> temp = new List<int>(); //space complexity is O(n)
            while (left <= mid && right <= high)
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
                left++;
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }
            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }

        }

        //Explaination =>
        //1. Divide the array into two halves.
        //2. Recursively sort the two halves.
        //3. Merge the two sorted halves.
        //4. Repeat this process until the entire array is sorted.

        #endregion

        #region QuickSort
        //----------------------------------Quick Sort----------------------------------------------------
        public static void QuickSort(ref int[] arr, int low, int high) //time complexity is O(nlogn) and space complexity is O(logn)
        {
            if (low < high)
            {
                int partition = GetPartition(ref arr, low, high); //time complexity is O(n) and space complexity is O(1)
                QuickSort(ref arr, low, partition - 1); //time complexity is O(nlogn) and space complexity is O(logn)
                QuickSort(ref arr, partition + 1, high);
            }
        }

        public static int GetPartition(ref int[] arr, int low, int high) //time complexity is O(n) and space complexity is O(1)
        {
            int pivot = arr[low];//space complexity is O(1)
            int left = low + 1;
            int right = high;
            while (left <= right && left < high)
            {
                while (arr[left] <= pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left > right) break;
                Swap(ref arr, left, right);

            }
            Swap(ref arr, low, right);
            return right;
        }
        #endregion

        //Explaination =>
        //1. Select a pivot element from the array.
        //2. Arrange the elements in the array such that all the elements less than the pivot are on the left side of the pivot and all the elements greater than the pivot are on the right side of the pivot.
        //3. Repeat this process for the left and right sub-arrays until the entire array is sorted.


        #region BubbleSort
        //public static void BubbleSort(ref int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                Swap(ref arr, j, j + 1);
        //            }
        //        }
        //    }
        //}
        public static void BubbleSort(ref int[] arr) // time complexity is O(n^2) and space complexity is O(1)
        {
            for (int i = arr.Length - 1; i > 0; i--)  // can also use While loop here  as while(i>0) i-- 
                for (int j = 0; j < i; j++)  
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr, j, j + 1);
                    }

                    //For ReverseSorting
                    /*
                    if(arr[j]>arr[j+1])
                    {
                        Swap(ref arr,j,j+1);
                    }                
                    */
                }
        }

        // Explaination => 1. Start from the first element of the array and compare it with the next element.
        // 2. If the element is greater than the next element, then swap the elements.
        // 3. Continue this process for all the elements of the array.
        // 4. Repeat this process for n-1 passes where n is the number of elements in the array.
        // 5. The largest element will be placed at the end of the array after the first pass.
        // 6. The second-largest element will be placed at the second last position after the second pass.
        // 7. Repeat this process for n-1 passes to sort the array.

        #endregion

        #region InsertionSort
        public static void InsertionSort(ref int[] arr) //time complexity is O(n^2) and space complexity is O(1)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        //Explaination = >
        //1. Start from the second element of the array and compare it with the previous elements.
        //2. If the element is smaller than the previous element, then swap the elements.
        //3. Continue this process until the element is greater than the previous element.
        //4. Repeat this process for all the elements of the array.

        #endregion

        #region SelectionSort
        public static void SelectionSort(ref int[] arr) //time complexity is O(n^2) and space complexity is O(1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref arr, i, minIndex);
            }
        }
        //Explaination =>
        //1. Find the minimum element in the array.
        //2. Swap the minimum element with the first element of the array.
        //3. Repeat this process for the remaining elements of the array.



        #endregion

        #region HeapSort
        public static void HeapSort(ref int[] arr) //time complexity is O(nlogn) and space complexity is O(1)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(ref arr, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                Swap(ref arr, 0, i);
                Heapify(ref arr, i, 0);
            }
        }

      public static void  Heapify(ref int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                Swap(ref arr, i, largest);
                Heapify(ref arr, n, largest);
            }
        }

        //Explaination =>
        //1. Build a max heap from the array.
        //2. Swap the root element with the last element of the array.
        //3. Remove the last element from the heap.
        //4. Heapify the remaining elements of the heap.
        //5. Repeat this process until the entire array is sorted.


        #endregion

    }
}
