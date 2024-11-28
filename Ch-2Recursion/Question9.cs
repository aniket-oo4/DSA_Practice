using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_2Recursion
{
    class Question9
    {

        // checking string is palindrome or not using functinal recursion 
        public static void Main(string[] args)
        {
            string s = "MaddaM", s2 = "Nobody";

            if (IsPalindrome(s,0))
            {
           Console.WriteLine("String " + s + "is Palindrome");
            }
            else
            {
        Console.WriteLine("String " + s + "is not Palindrome");
            }

            if (IsPalindrome(s2,0))
            {
                Console.WriteLine("String " + s2 + "is Palindrome");
            }
            else
            {
                Console.WriteLine("String " + s2 + "is not Palindrome");
            }

        }


        public static bool IsPalindrome(string str,int i)
        {
            if (i >= str.Length / 2) // time complexity == O(n/2)
                return true ;
            if(str[i]!=str[str.Length-i-1])
                return false;
            return IsPalindrome(str, i + 1);
        }
    }
}
