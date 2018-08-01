namespace LeetCodes
{
    public class A033RotatedSortedArray
    {
        
        [Solution(IsSolution = true)]
        public int Search(int[] nums, int target)
        {
            offset = FindRotatedPoint(nums);
            len = nums.Length;
            int low = 0, high = len - 1, mid = (low + high) / 2;
            while (high >= low)
            {
                if (nums[Index(mid)] == target)
                {
                    return Index(mid);
                }
                else if (nums[Index(mid)] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

                mid = (low + high) / 2;
            }

            return -1;
        }

        public static int offset;
        public static int len;

        public int Index(int index)
        {
            return (index + offset) % len;
        }

        public int FindRotatedPoint(int[] nums)
        {
            int high = nums.Length - 1, low = 0, mid = (low + high) / 2;

            while (high > low)
            {
                if (nums[mid] > nums[mid + 1])
                {
                    return mid + 1;
                }
                else
                {
                    if (nums[mid] > nums[nums.Length - 1])
                    {
                        low = mid + 1;
                        mid = (low + high) / 2;
                    }
                    else
                    {
                        high = mid;
                        mid = (low + high) / 2;
                    }
                }
            }

            return 0;
        }
    }
}