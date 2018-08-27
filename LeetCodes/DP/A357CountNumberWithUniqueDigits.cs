namespace LeetCodes
{
    public class A357CountNumberWithUniqueDigits
    {
        public int CountNumbersWithUniqueDigits(int n) {
            if (n <= 0)
                return 1;

            if (n == 1)
                return 10;

            if (n > 10)
                n = 10;
            
            //for 2 bit number, unique number is [1-9] | [0-9 except first digit number],
            //hence choices are 9 * (10-1)
            //simalar for n bit number(3 <= n <= 10), choice is 9 * 9 * 8 *...* (10-n+1)

            int uniqueNumOfNDigits = 9, bases = 9, res = 10;
            for (int i = n - 1; i > 0; i--)
            {
                uniqueNumOfNDigits *= bases;
                res += uniqueNumOfNDigits;
                bases--;
            }

            return res;
        }
    }
}