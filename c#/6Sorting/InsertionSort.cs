using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sorting
{/*
  * Insertion sort is nothing but the sort which selects an element and places it at the right position 
  * eg if i is 4 and value of that index is 71 it will look backward indexes susch as 3,2,1,0  and swaps with them untill the !arr[i]>arr[current](71);
  *  
  *  algo 
  *     for i=0;i<length-1;i++
  *     int j=i; //j is  current  and j-1 is previous 
  *         while( j>0 && arr[j]<arr[j-1])
  *             swap (arr[j],arr[j-1]);
  *             j--;
  *             
  *   Complexities 
  *   calculate by taking and example of 
  *     input =[5,4,3,2,1];
  *     and for best case - [1,2,3,4,5]
  *     
  *     Worst case : o(n^2)  :o(n*(n+1/2))
  *         proof:
  *             for input 54321 
  *                 for  the 5 it takes 0 swaps --iteration 
  *                     for 4 ->1  
  *                             3->2
  *                                 2->3
  *                                     1->4
  *                       observe the pattern it will take  , n ,n+1,n+2,n+3,n+4  = sum of first natural numbers  = (n*n+1/2)  logical ans=O(n^2) where n=5 ;5*(5+1/2)=5*3=15 ,<--sum
  * 
  *    Average Case :--> O(n^2)
  *    for best Case  : O(n)// inner loop never gets execute if the order is already sorted 
  *        proof:
  *             for input 12345 
  *                 for  the 1 it takes 0 swaps  -- iteration
  *                     for 2 ->0  
  *                             3->0
  *                                 4->0
  *                                     5->0
  *    
  * */
    internal class InsertionSort
    {
        public static void Main(String[] args)
        {
            int[] input = new int[] { 12, 34, 2, 133, 564, 23, 1, 85, 356, 857, 6, 9698, 4 };
            foreach(var element in input)
            {
                Console.Write(" " + element);
            }

            InsertionSort.funcInsertionSort(ref input,input.Length-1);
            Console.WriteLine("\nAfter Insertion sort : ");
            foreach (var element in input)
            {
                Console.Write(" " + element);
            }

        }
    


    public static void funcInsertionSort(ref int[] arr, int n)
        {
            for (int i = 0; i <= n; i++) //O(n)   -- carefully observe the size and length of arr and comparison must be goes till end 
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    BubbleSort.Swap(ref arr, j, j - 1);
                    j--;// carefully observe the full code  and dry run it 
                }
            }
        }
    }
}
