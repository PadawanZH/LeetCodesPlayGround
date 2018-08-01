using System;
using System.Collections.Generic;

namespace LeetCodes
{
    public class A032LongestValidParentheses
    {
        public int LongestValidParentheses_stack(string s) {
            Stack<int> stack = new Stack<int>();
            
            stack.Push(-1);

            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, i - stack.Peek());
                    }
                }
            }

            return maxCount;
        }

        [Solution(IsSolution = true)]
        public int LongestValidParentheses_dp(string s)
        {
            int[] dp = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = 0;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (s[i - 1] == '(')
                    {
                        dp[i] = ((i >= 2)? dp[i - 2] : 0) + 2;
                    }

                    if (s[i - 1] == ')')
                    {
                        if (i - dp[i - 1] - 1 >= 0 && s[i - dp[i - 1] - 1] == '(')
                        {
                            dp[i] = dp[i - 1] + dp[((i - dp[i - 1] >= 2) ? i - dp[i - 1] - 2 : 0) ] + 2;
                        }
                    }
                }
            }

            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                res = (res >= dp[i]) ? res : dp[i];
            }

            return res;
        }
    }
}