namespace LeetCodes
{
    public class A416PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum % 2 != 0)
            {
                return false;
            }
            else
            {
                return CanPartition(nums, sum / 2);
            }
        }

        public bool CanPartition(int[] nums, int target)
        {
            bool[] dp = new bool[target + 1];
            dp[0] = true;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = target; j >= nums[i]; j--)
                {
                    dp[j] = dp[j] || dp[j - nums[i]];
                }
            }

            return dp[target];
        }
    }
}