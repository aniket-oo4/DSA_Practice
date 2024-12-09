namespace LeetCodeQuestions
{

    //3379. Transformed Array
    internal class Transformed_Array3379
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            foreach(var ele in ConstructTransformedArray(new int[] { -1, 4, -1 })) 
            {
                Console.Write(ele + " ");
            }
        }
        public static  int[] ConstructTransformedArray(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int j;
            for (j = 0; j < n; j++) 
            {
                result[j] = nums[GetNextIndex(nums, j, nums[j])];
            }
            return result;
        }
        public static int GetNextIndex(int[] arr, int i, int currentValue)
        {
            if (currentValue > 0)
            {
                while (currentValue > 0)
                {
                    if (i + 1 > arr.Length - 1)
                    {
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                    currentValue -= 1;
                }
            }
            else if (currentValue < 0)
            {
                currentValue *= -1;
                while (currentValue > 0)
                {
                    if (i - 1 < 0)
                    {
                        i = arr.Length - 1;
                    }
                    else
                    {
                        i -= 1;
                    }
                    currentValue -= 1;
                }
            }
            else
            {
                return i;
            }
            return i;
        }

    }
}
