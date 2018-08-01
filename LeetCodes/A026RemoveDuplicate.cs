using System;

namespace LeetCodes
{
    public class A026RemoveDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++i] = nums[j];
                }
            }

            return nums.Length == 0? 0: i + 1;
        }

        
    }
}