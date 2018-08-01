using System;
using System.Linq;

namespace LeetCodes
{
    public class A008Atoi
    {
        [Solution(IsSolution = true)]
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            str = tirm(str);
            bool isPositive = true;
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            if (str[0] == '-')
            {
                isPositive = false;
                str = str.Substring(1);
            }
            else if(str[0] == '+')
            {
                str = str.Substring(1);
            }
            
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            if (str.IndexOf('.') != -1)
            {
                str = str.Substring(0, str.IndexOf('.'));
            }
            
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!isDigit(str[i]))
                {
                    break;
                }

                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 &&  (str[i] - 48) > 7))
                {
                    return (isPositive) ? Int32.MaxValue : Int32.MinValue;
                }
                result = result * 10 + (str[i] - 48);
            }

            return (isPositive) ? result: -result;
        }


        public string tirm(string str)
        {
            int i = 0;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    break;
                }
            }

            int lastDigit = 0;
            bool found = false; //to prevent str like "+"
            for (lastDigit = str.Length - 1; lastDigit >= i; lastDigit--)
            {
                if (isDigit(str[lastDigit]))
                {
                    found = true;
                    break;
                }
            }
            
            
            return (found) ? str.Substring(i, lastDigit - i + 1) : str.Substring(i);
        }

        

        public bool isDigit(char ch)
        {
            return ch >= 48 && ch <= 57;
        }
    }
}