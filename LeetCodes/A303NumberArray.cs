namespace LeetCodes
{
    public class A303NumberArray
    {
        public int[] Cumulate;
        
        public void NumArray(int[] nums) {
            if (nums != null && nums.Length != 0)
            {
                Cumulate = new int[nums.Length];
                Cumulate[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    Cumulate[i] = Cumulate[i - 1] + nums[i];
                }
            }
            
        }
    
        public int SumRange(int i, int j)
        {
            return Cumulate[j] - ((i - 1 >= 0)? Cumulate[i - 1] : 0);
        }
    }
}