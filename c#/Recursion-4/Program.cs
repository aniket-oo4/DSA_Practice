namespace Recursion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PrintNTo1(10);
            Print1ToN(10);
        }
        
        public static void Print1ToN(int n)
        {
            if (n == 0) return;
            Print1ToN(n-1);
            //Print1ToN(--n);//check using pre increment it will gives you result from 0 - 9
            //Print1ToN(n --); // Gives StackOverFlow it calls method 16K Times  
            Console.WriteLine("n:" + n);
        }
        public static void PrintNTo1(int n)
        {
            if (n == 0) return;
            Console.WriteLine("n: " + n);
            PrintNTo1(--n);
        }
    }
}
