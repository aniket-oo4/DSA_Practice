using System;



public class Solution {

    public void Merge(ref int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0) {
            nums1[k--] = nums2[j--];
        }
    }


}

class LC88
{
    public static void Main(String[] args)
    {
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = new int[] { 2, 5, 6 };
        Solution sol = new Solution();
        sol.Merge(ref nums1, 3, nums2, 3);
        foreach (var element in nums1)
        {
            Console.Write(" " + element);
        }
    }
}