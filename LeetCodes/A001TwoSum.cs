using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    public class A001TwoSum
    {
        [Solution(IsSolution = true)]
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target - nums[i] == nums[j])
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return new int[]{};
        }
    }
}