using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question2
    {
        static void Main(string[] args)
        {
            Print1toN(1, 10);
        }

        public static void Print1toN(int i,int n)
        {
            if (i > n)///base Case 
                return;
            Console.WriteLine(i);
            Print1toN(++i, n);
        }

    }
}
