using System;

namespace problems
{
    class Program
    {
        public static void IsEquallyDistributable(int w)
        {
            Console.Write((w % 2 == 0 && w != 0) ? "YES" : "NO");
        }

        public static void Main(String[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            IsEquallyDistributable(weight);
        }

    }

}