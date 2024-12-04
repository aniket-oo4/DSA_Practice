namespace Recursion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PrintNTo1(10);
            //Print1ToN(10);
            //Print1ToN(1, 10);

            //Methods that Returns /Gives Back Something 


            //Console.WriteLine("PArameterised  The Sum of First 10 Natural Numbers  :" + sumOfFirstN(10,0));
            //Console.WriteLine("Functional  The Sum of First 10 Natural Numbers  :" + SumOfFirstN(10));
            //Console.WriteLine("Factirial of 5 : " + Factorial(5));

            //int[] arr = { 3, 1, 4, 2, 77, 5, 33, 90 };
            //PrintArray(arr);
            //ReverseArray(arr, 0, arr.Length - 1); // using two pointers 
            //ReverseArray(arr, 0);//using single variable 
            //PrintArray(arr);

            String str = "MadaM";String str2 = "hello";
            //Console.WriteLine(" String is Palindrome  or not  :" + IsPalindrome(str,0));
            Console.WriteLine(" String is Palindrome  or not  :" + IsPalindrome(str2, 0));
            Console.WriteLine(" String is Palindrome  or not  :" + IsPalindrome(str, 0,str.Length-1));
        }

        //------Recursive Methods That Prints Something Does not returns  
        #region
        // using 2 variables 
        public static void Print1ToN(int i,int n)
        {
            if (i > n) return; // base case for the recursion end remeber that the return statement is must in Recursion 

            Console.WriteLine("N:" + i);
            Print1ToN(i+1, n); //1-10
            //Print1ToN(i, n - 1);//1*10times
            // Print1ToN(i + 1, n - 1);// 1-5

        }
        public static void PrintNTo1(int n)
        {
            if (n == 0) return;
            Console.WriteLine("n: " + n); //<-- Firstly called method  body executeld First tthen the recursive call made 
            PrintNTo1(--n); //<-- Recursive call after Executing firstly called method body 
        }

        // The BackTracking Approaches --> 
        public static void Print1ToN(int n)
        {
            if (n == 0) return;
            Print1ToN(n - 1);  // <-- Backtracks Means   it will calls itself first and  it Confirms that the short  calculation will did after the result of backtrack  
            //Print1ToN(--n);//check using pre increment it will gives you result from 0 - 9
            //Print1ToN(n --); // Gives StackOverFlow it calls method 16K Times  
            Console.WriteLine("n:" + n); // <-- First Called method body executed Lastly here 
        }

        #endregion
        //--------------------------------------------------

        //  Recursive Methods That gives Something Back Returns 

        #region 


        //Parameterised Approach 
        public static int sumOfFirstN(int n ,int sum)
        {
            if (n == 0)
            {
                return sum;// or print sum then return 
            }
            return sumOfFirstN(n - 1, sum + n); //<-- value of First n has been continued as an addition to the parameter , thats why it called as parameterised approach 
        }


        // Its Funtional Approach 
        public static int SumOfFirstN(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + SumOfFirstN(n - 1);  //<-- Firstly Call Method body  Executes at Last here is backTracked answer 

        }

        public static int Factorial(int n)
        {  
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        

        // Re- 4

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("--------------------------------");
            foreach(var ele in arr)
            {
                Console.WriteLine(ele);
            }
        }
        public static void SwapArray<T>(ref T [] arr,int i,int n)
        { 
            T temp = arr[i];
            arr[i] = arr[n];
            arr[n] = temp;
        }
        public static void ReverseArray(int[] arr,int i,int n) // using two pointers  // O(Log n) n/2 
        {
            if (i >= n) return;
            SwapArray<int >(ref arr, i, n); //<-- first Swaps then recursive call  FCFE first call first execution 
            ReverseArray(arr, i + 1, n - 1);
        }
        public static void ReverseArray(int [] arr, int i )
        {
            if (i > arr.Length/2) return ; //O(log n) n/2
            SwapArray<int>(ref arr, i, arr.Length - i - 1); // last -1 is for last index 
            ReverseArray(arr, i + 1);
        }

        // Palindrom string check 

        public static bool IsPalindrome(string str ,int i)
        {
            if (i >= str.Length - i - 1) // o(log n)  n/2 cause we are doing like two pointers // but only using single variable 
            {
                return true;
            }
            if (str[i] != str[str.Length - i - 1])
                return false;
            return IsPalindrome(str, i + 1);

        }
        
        public static bool IsPalindrome(string str , int left , int right)
        {
            if(left>=right)
                return true;
            if (str[left] != str[right])
                return false;

            return IsPalindrome(str, left + 1, right - 1);
        }


        #endregion 

    }
}
