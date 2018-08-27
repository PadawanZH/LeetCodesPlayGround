using System;

namespace LeetCodes
{
    public class A740DeleteAndEarn
    {
        [Solution(IsSolution = true)]
        public int DeleteAndEarn(int[] nums) {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            
            Array.Sort(nums);
            
            
            int[] dp = new int[nums.Length + 1];
            dp[nums.Length] = 0;
            dp[nums.Length - 1] = nums[nums.Length - 1];
            int lastCommonPointer = nums.Length;
            int lastlastChoice = nums.Length;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] != nums[i + 1])
                {
                    lastlastChoice = lastCommonPointer;
                    lastCommonPointer = i + 1;   
                }

                if (lastCommonPointer < nums.Length && nums[lastCommonPointer] - nums[i] > 1)
                {
                    dp[i] = dp[i + 1] + nums[i];
                }
                else
                {
                    dp[i] = Math.Max(nums[i] * (lastCommonPointer - i) + dp[lastlastChoice],  dp[lastCommonPointer]);
                }
            }

            return dp[0];
        }
    }
}