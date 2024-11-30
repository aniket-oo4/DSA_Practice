﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_1Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("10+20 ::" + Program.Add(10, 20));
            int cnt = 0;
            Program.Print(ref cnt);
            Program.Print1ToCnt(cnt);

        }

        public static int Add(int a, int b)
        {

            return a + b;
        }

        public static void Print(ref int cnt)
        {
            if (cnt == 4)
            {
                Console.WriteLine("count :"+cnt);
                return;
            }

            Console.WriteLine(" count :" + cnt);
            cnt++;
            Print(ref cnt);
        }

        public static void Print1ToCnt(int cnt ) // Funtional recursion 
        {
            if (cnt == 1)
            {
                Console.WriteLine(cnt);
                return; // this return statement is must in case of method is void then also 
            }

            Print1ToCnt(cnt - 1);
            Console.WriteLine(cnt);


        }
    }

}

