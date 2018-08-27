namespace LeetCodes
{
    public class A494TargetSum
    {
        [Solution(IsSolution = true)]
        public int FindTargetSumWays(int[] nums, int S)
        {
            return FindTargetSumWays_DP(nums, S);
        }

        public int FindTargetSumWays_DP(int[] nums, int S)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int tarSum = S + sum;

            if (sum < S || tarSum % 2 != 0)
            {
                return 0;
            }
            else
            {
                return subSetSum(nums, (tarSum) / 2);
            }
        }

        public int subSetSum(int[] nums, int tar)
        {
            int[] dp = new int[tar + 1];
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = 0;
            }
            dp[0] = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = tar; j >= nums[i]; j--)
                {
                    dp[j] += dp[j - nums[i]];
                }
            }

            return dp[tar];
        }
        
        //DFS
        
        public int FindTargetSumWays_DFS(int[] nums, int S)
        {
            int count = 0;
            FindTargetSumWays(nums, S, 0, ref count);
            return count;
        }

        public void FindTargetSumWays(int[] nums, int S, int start, ref int count)
        {
            if (start == nums.Length)
            {
                if (S == 0)
                {
                    count++;
                }
                return;
            }
            
            //choose +
            FindTargetSumWays(nums, S - nums[start], start + 1, ref count);
            //choose -
            FindTargetSumWays(nums, S + nums[start], start + 1, ref count);
        }
    }
}