namespace LeetCodes
{
    public class A034RangeSortedArray
    {
        [Solution(IsSolution = true)]
        public int[] SearchRange(int[] nums, int target)
        {
            int tarStart, tarEnd;
            tarStart = tarEnd = BinarySearch(nums, 0, nums.Length - 1, target);
            if (tarStart == -1)
            {
                return new []{-1, -1};
            }

            int left = tarStart - 1;
            while (left != -1)
            {
                left = BinarySearch(nums, 0, left, target);
                tarStart = (left == -1) ? tarStart : left;
                left = (left == -1) ? -1 : left - 1;
            }

            int right = tarEnd + 1;
            while (right < nums.Length && right != -1)
            {
                right = BinarySearch(nums, right, nums.Length, target);
                tarEnd = (right == -1) ? tarEnd : right;
                right = (right == -1) ? -1 : right + 1;
            }
            
            return new int[]{tarStart, tarEnd};
        }

        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            int high = end, low = start, mid = (low + high) / 2;
            while (high >= low)
            {
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] < target)
                {
                    low = mid + 1;
                    mid = (high + low) / 2;
                }
                else
                {
                    high = mid - 1;
                    mid = (high + low) / 2;
                }
            }

            return -1;
        }
    }
}