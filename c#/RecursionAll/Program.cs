namespace RecursionAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            String s = "MADAM";
            if (IsPalindrome(s, 0, s.Length))
            {
                Console.WriteLine("String is palindrome ");
            }
            else 
            {
                Console.WriteLine("String is not palindrome");
            }

            Console.WriteLine(IsPalindrome("Hello", 0, "Hello".Length));

        }


        public static bool IsPalindrome(String str, int i, int n)
        {
            if (i >= n / 2)
            {
                Console.WriteLine("String is palindrome ");
                return true;
            }
               
            if (str[i] != str[n - i - 1])
            {
                Console.WriteLine("String is not palindrome ");
                return false;
            }
               
            return IsPalindrome(str, i + 1, n);

        }


    }
}
