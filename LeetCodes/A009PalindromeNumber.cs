using System;

namespace LeetCodes
{
    public class A009PalindromeNumber
    {
        public bool IsPalindrome(int x) {
            if (x < 0)
            {
                return false;
            }

            return x == ReverseNum(x);
        }
        public int ReverseNum(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            int result = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (result > Int32.MaxValue / 10)
                {
                    return 0;
                }

                result = result * 10 + digit;
                num /= 10;
            }

            return result;
        }
    }
}