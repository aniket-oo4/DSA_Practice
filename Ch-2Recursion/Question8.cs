using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question8
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 3, 5, 1 };
            Console.Write("before Reversing :\n");
            foreach (var element in arr)
            {
                Console.Write(" " + element);
            }

            //ReverseArray(arr,0, arr.Length); // using single variable 
            ReverseArray(0, arr, arr.Length - 1);// using Two Pointers 
            Console.Write("\nafter Reversing :\n");
            foreach (var element in arr)
            {
                Console.Write(" " + element);
            }


           
        }

        public static void Swap(ref int a, ref int b)
        {
             a+=b;
             b = a - b;
             a = a-b;
        }


        /// <summary>
        /// Functioanal approach 
        /// Single variable 
        /// </summary>
        /// <param name="arr"> array </param>
        /// <param name="i"> index start</param>
        /// <param name="n"> total length of array </param>
        public static void ReverseArray(int[] arr, int i, int n)
        {
            if (i >= n / 2)  // time complexisty == O(n/2)
                return;
            Swap(ref arr[i], ref arr[n - i - 1]);
            ReverseArray(arr,i + 1, n);  // using only i (single variable ) 

        }



        // using two pointers 
        public static void ReverseArray(int l, int[] arr, int r)
        {
            if (l >= r) // time complexisty == O(n/2)
            {
                return;
            }
            Swap(ref arr[l], ref arr[r]);
            ReverseArray(l + 1, arr, r - 1);
        }

    }
}
