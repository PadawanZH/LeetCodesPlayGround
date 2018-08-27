using System;

namespace LeetCodes
{
    public class A712MinASCIIDeleteSum
    {
        [Solution(IsSolution = true)]
        public int MinimumDeleteSum(string s1, string s2) {
            if (String.IsNullOrEmpty(s1) || String.IsNullOrEmpty(s2))
            {
                return 0;
            }

            int[] dpLastRow = new int[s2.Length + 1], dpCurRow = new int[s2.Length + 1];
            Array.Fill(dpLastRow, 0);
            Array.Fill(dpCurRow, 0);
            
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                sum1 += s1[i];
            }

            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dpCurRow[j] = dpLastRow[j - 1] + s1[i - 1]; // don't delete anyone
                    }
                    else
                    {
                        dpCurRow[j] = Math.Max(dpLastRow[j], dpCurRow[j - 1]);
                    }
                }

                int[] temp = dpCurRow;
                dpCurRow = dpLastRow;
                dpLastRow = temp;
            }

            return sum1 + sum2 - 2 * dpLastRow[s2.Length];
        }
    }
}