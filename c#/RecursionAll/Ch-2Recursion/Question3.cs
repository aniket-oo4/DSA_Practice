using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question3
    {
        public static void Main(string[] args)
        {
           PrintNto1(4);
           //ConsoleKeyInfo key= Console.ReadKey();
           //Console.WriteLine(key.Key +" "+key.KeyChar+ " "+key.Modifiers+"  "+key.ToString()  );
           //Console.ReadKey();
        }

        internal static void PrintNto1(int n)
        {
            if (n < 1)///base Case 
                return;
            Console.WriteLine(n);
            PrintNto1(--n);
        }
    }
}
