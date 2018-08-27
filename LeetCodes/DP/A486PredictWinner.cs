using System;

namespace LeetCodes
{
    public class A486PredictWinner
    {
        public bool PredictTheWinner(int[] nums) {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            if (nums.Length % 2 == 0)
            {
                return true;
            }

            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            int[,] dp = new int[nums.Length,nums.Length];

            for (int j = 0; j < nums.Length; j++)
            {
                int curSum = 0;
                for (int i = j; i >= 0; i--)
                {
                    curSum += nums[i];
                    if (i == j)
                    {
                        dp[i, j] = nums[i];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(curSum - dp[i + 1, j], curSum - dp[i, j - 1]);
                    }
                }
            }

            return dp[0, nums.Length - 1] * 2 >= sum;
        }
    }
}