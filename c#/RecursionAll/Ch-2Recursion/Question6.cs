using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question6
    {

       public static void Main(string[] args){
            Console.WriteLine("Enter num ::");
           // int n = Convert.ToInt32(Console.ReadLine());
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {

            }
            else
            {
                num=0;
            }
            if (num>0)
            {
                Console.WriteLine("Factorial of number :" + num + "  : " + GetFactorial(num));
            }



        }

        public static int   GetFactorial(int n){
            if (n == 1) ///base case 
                return n;
            int result =n;
            result*=GetFactorial(n-1); // it goes until base case then returns the values returned by previous method calls and multiply it by current value of n 
            //you can also use it as  return n*GetFactorial(n-1);
            return result;
        }

    }
}
