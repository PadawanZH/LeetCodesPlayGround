using System;

namespace LeetCodes
{
    public class A029DivideTwoNumber
    {
        [Solution(IsSolution = true)]
        public int Divide(int dividend, int divisor)
        {
            int sign = (dividend >> 31 ^ divisor >> 31);
            if (divisor == Int32.MinValue)
            {
                if (dividend == Int32.MaxValue) return -1;
                return dividend == Int32.MinValue ? 1 : 0;
            }
            if (dividend == Int32.MinValue)
            {
                if (divisor == Int32.MaxValue) return -1;
                if (divisor == 1)
                {
                    return Int32.MinValue;
                }

                if (divisor == -1)
                {
                    return Int32.MaxValue;
                }
                if ((abs(divisor) == 2 || abs(divisor) == 4 || abs(divisor) == 8))
                {
                    return (sign == 0)
                        ? FindMultiplier(abs(dividend), abs(divisor)) + 1
                        : ~FindMultiplier(abs(dividend), abs(divisor));
                }
            }
            
            return (sign == 0)
                ? FindMultiplier(abs(dividend), abs(divisor))
                : ~FindMultiplier(abs(dividend), abs(divisor)) + 1;
        }

        public int FindMultiplier(int dividend, int divisor)
        {
            if (dividend < divisor) return 0;
            int multiplier = 1;
            int sum = divisor;
            while (dividend - sum >= sum)
            {
                sum += sum;
                multiplier += multiplier;
            }

            return multiplier + FindMultiplier(dividend - sum, divisor);
        }

        public int abs(int x)
        {
            if(x == Int32.MinValue) return Int32.MaxValue;
            int y = (x >> 31);
            return (x ^ y) - y;
        }
    }
}