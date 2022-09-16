using System;
using System.Collections.Generic;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        j++;
                    }
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }

        public int[] TwoSumDict(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> walked = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                var rest = target - nums[i];
                if (walked.ContainsKey(rest))
                    return new int[]{walked[rest], i
    };
                else
                    if (!walked.ContainsKey(nums[i]))
                    walked.Add(nums[i], i);
            }
            return new int[0];
        }
    }
}
