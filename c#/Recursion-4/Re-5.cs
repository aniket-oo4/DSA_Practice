using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_4
{
    internal class Re_5
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Ganpati bappa morya ");
            //fibonacci series 
            int n = 7;
            Console.WriteLine($"n :{n}th fibonacci is {nThFibonacci(n)} ");
        }

        // multipler recursive calls in one method 
        public static int nThFibonacci(int n)
        {
            if(n==0 || n == 1)
            {
                return n;
            }
            int last = nThFibonacci(n-1);
            int secondLast = nThFibonacci(n-2); ;
            // always remeber the  next recursion calls nevere ever gets executed until all the previous calls gets returned
            return last + secondLast;
            return nThFibonacci(n-1) + nThFibonacci(n-2);
            // time complexity is  exponential in nature cause there is multiple call for every recursive call 
            /*
             *  for f(4) there if f(3)+ f(2)    and for f(3) is f(2) + f(1)
             *  hence time complexity is  o(2 ^n) 
             * 
             * */
        }
    }
}
