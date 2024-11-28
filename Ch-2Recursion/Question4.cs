using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question4
    {
        //use backtracking 
        // Backtracking ensures that the last guy is executed first 
        // in backtracking The Result will only get if the Base Case gets Execute
        public static void Main(string[] args)
        {
            int n=10;
            //Print1ToNbacktracking(n, n);  // this method executes end to start  (second  n is not used 
            Print1ToNbacktracking(n);  
        }

        public static void Print1ToNbacktracking(int i, int n)
        {
            if (i < 1) ///base Case 
                return;
            Print1ToNbacktracking(i - 1, n);

            Console.WriteLine(i);   // check  it was executes after the last call terminates and so on 

        }

            //iterator represented as    
         public static void Print1ToNbacktracking( int n)
        {
            if (n < 1)
                return;
            Print1ToNbacktracking(n - 1);

            Console.WriteLine(n);   // check  it was executes after the last call terminates and so on 

        }
    }
}
