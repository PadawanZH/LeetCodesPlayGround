namespace LeetCodes
{
    public class A035SearchInsert
    {
        [Solution(IsSolution = true)]
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}