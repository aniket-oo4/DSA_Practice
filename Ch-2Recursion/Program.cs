using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{

    //Print the name n times using Recursion 
    class Program
    {
        static void Main(string[] args)
        {
            PrintName(1,5);
        }

        public static void PrintName(int i,int n)
        {
            if (i > n)///base Case 
                return;
            Console.WriteLine("MName ");
            i++;
            PrintName(i,n);
        }
        //Time Complexity -->O(n)
        //Space Complexity-->O(n)  cause  n  method calls are waited in stack untill the terminated 
            


    }
}
