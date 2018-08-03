namespace LeetCodes
{
    public class A338CountBits
    {
        //Basic idea: if n = xxx100 then n-1 = xxx011
        //hence, n & n-1 = xxx000
        //therefore, bit(n) = bit(n & n-1) + 1
        public int[] CountBits(int num) {
            int[] res = new int[num + 1];
            res[0] = 0;
            
            for (int i = 1; i <= num; i++)
            {
                res[i] = res[i & (i - 1)] + 1;
            }

            return res;
        }
    }
}