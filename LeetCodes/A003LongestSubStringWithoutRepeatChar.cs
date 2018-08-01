using System;

namespace LeetCodes
{
    public class A003LongestSubStringWithoutRepeatChar
    {
        [Solution(IsSolution = true)]
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int startIndex = 0;
            int subStringLength = 1;
            int nextIndex = 1;
            int maxLength = 1;
            while (nextIndex < s.Length)
            {
                while(nextIndex < s.Length && FindIndex(s.Substring(startIndex, subStringLength), s[nextIndex]) == -1)
                {
                    subStringLength++;
                    nextIndex++;
                }
                maxLength = (subStringLength > maxLength)? subStringLength: maxLength;
                
                if (nextIndex < s.Length)
                {
                    startIndex = startIndex + FindIndex(s.Substring(startIndex, subStringLength), s[nextIndex]) + 1;
                    subStringLength = nextIndex - startIndex + 1;
                    nextIndex++;
                }
                else
                {
                    break;
                }
            }

            return maxLength;
        }
        
        public int FindIndex(string str, char target)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}