namespace Contest1CDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = input[0];
                int a = input[1] - 1;
                int b = input[2] - 1;
                int[] arr = new int[n];
                int flag = 1;
                arr[a - 1] = 1;
                arr[b - 1] = 1;
                while (flag != 0)
                {
                    if (a - 1 < 0 || arr[a-1]==1)
                    {
                        if (a + 1 >= n)
                        {
                            flag = 0;
                            break;
                        }
                        else if (arr[a+1]==1)
                        {
                            flag = 0;
                            break;
                        }
                        else
                        {
                            arr[a] = 0;
                            arr[a + 1] = 1;
                        }
                    }
                    else
                    {
                        if ((a + 1) >= n || arr[a+1]==1)
                        {

                        }
                        else if (arr[a - 1] == 1)
                        {
                            flag = 0; return;  
                        }
                        else
                        {
                            arr[a] = 0;
                            arr[a - 1] = 1;
                        }
                    }
                }

            }
        }
    }
}

/*
 * 5
2 1 2
3 3 1
4 2 3
5 2 4
7 6 2
 * 
 */
