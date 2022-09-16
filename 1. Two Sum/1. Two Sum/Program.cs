using System;

namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Solution sol = new Solution();
            int[] arr = sol.TwoSum(nums, target);

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            int[] arr2 = sol.TwoSumDict(nums, target);
        }

    }
}
