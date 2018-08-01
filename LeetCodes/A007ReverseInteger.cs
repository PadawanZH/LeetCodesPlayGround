using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    public class A007ReverseInteger
    {
        [Solution(IsSolution = true)]
        public int Reverse(int x)
        {
            
            if (x == 0)
                return 0;

            int result = 0;
            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;
                if (Math.Abs(result) > (Int32.MaxValue / 10))
                {
                    return 0;
                }
                result = ((result * 10) + digit);
            }
            
            return result;
        }
    }
}