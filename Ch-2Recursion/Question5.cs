using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    //BackTracking
    class Question5
    {
        public static void Main(string[] args)
        {
            int n = 10;
            //Print1ToNbacktracking(n, n);  // this method executes end to start  (second  n is not used 
            PrintNTo1backtracking(1,n);
        }

        public static void PrintNTo1backtracking(int i, int n)
        {
            if (i > n)
                return;
            PrintNTo1backtracking(i + 1, n);

            Console.WriteLine(i);
        }

    }
}
