using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    //parameterised and funcitonal Recursion '
    // video : Re3.Parameterised and Functional recursion  
    class Question7
    {
        public static void Main(string[] args){
        
            SumOf1ToN(10, 0);

            Console.WriteLine("Sum using functiopnal Approach :" + SumOf1ToN(10));

            //factorial 
            Factorial(5, 1);

            //Functional approcach 
            Console.WriteLine("Factorial using functiopnal Approach :" + Factorial(5));



        }

        //Parameterised  approach 
            //--> where we keep the values as parameters from start to the end (base case ) and  when an base case executes we prints 
        public static void SumOf1ToN(int i, int sum)
        {
            if (i < 1)
            {
                Console.WriteLine("Sum :"+sum);
                return;
            }

            SumOf1ToN(i-1,sum+i);
        }


       //functional approach --\
        //in this case function will returns the value not prints inside the functional only 
        public static int SumOf1ToN(int n)
        {
            if (n == 0)
                return n;
            return n + SumOf1ToN(n - 1); // used bactracking 
            //also did as 
            //int result=0;
            //result = n ; 
            //result+=SumOf1ToN(n - 1);
            //return result; <-- returns after base case 
        }

       
        //Factorial 

        public static void Factorial(int n, int fact)
        {
            if (n == 0)
            {
                Console.WriteLine("Factorial is :"+fact);
                return;
            }

            Factorial(n - 1, fact * n);
        }


        public static  int Factorial(int n)
        {
            if(n==0) //executes first if(n==1) return n;
                return 1;

            return n*Factorial(n-1); // 

            /*f(5)-->5*f(4)-->4*f(3)-->3*f(2)-->2*f(1)-->1*f(0)
             *120 <--4*24  <-- 4*6  <-- 3*2 <-- 2*1  <--  1
            */

        }



    }
}
