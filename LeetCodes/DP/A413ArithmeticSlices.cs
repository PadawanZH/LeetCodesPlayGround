using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace LeetCodes
{
    public class A413ArithmeticSlices
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            if (A == null || A.Length <= 2) return 0;
            List<int> lens = new List<int>();

            int count = 2;
            int difference = A[1] - A[0];
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] - A[i - 1] != difference)
                {
                    if (count >= 3)
                    {
                        lens.Add(count);
                    }
                    count = 2;
                    difference = A[i] - A[i - 1];
                }
                else
                {
                    count++;
                }
            }
            if(count != 0) lens.Add(count);

            int res = 0;
            foreach (var len in lens)
            {
                res += ((len - 2) * (len + 1) - (((len * (len + 1)) / 2) - 3) );
            }

            return res;
        }
    }
}