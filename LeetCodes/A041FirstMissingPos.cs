using System.Linq;

namespace LeetCodes
{
    public class A041FirstMissingPos
    {
        public int FirstMissingPositive(int[] nums)
        {
            nums = nums.OrderBy(a => a).ToArray();
            int res = 0;
            foreach (var n in nums)
            {
                if (res == n)
                {
                    res++;
                }
            }

            return res;
        }
        
        
    }
}