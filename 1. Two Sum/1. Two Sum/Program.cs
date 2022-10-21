using System;

namespace _1._Two_Sum
{
    internal class Program
    {
        /* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.*/
        
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
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}
