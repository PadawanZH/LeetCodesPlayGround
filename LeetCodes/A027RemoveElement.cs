namespace LeetCodes
{
    public class A027RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = -1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[++i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}