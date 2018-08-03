using System;

namespace LeetCodes
{
    public class A198HouseRobber
    {
        public int Rob(int[] nums) {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1) return nums[0];
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = Math.Max(nums[0], nums[1]);
            dp[1] = max;

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
                max = (max > dp[i]) ? max : dp[i];
            }

            return max;
        }
    }
}