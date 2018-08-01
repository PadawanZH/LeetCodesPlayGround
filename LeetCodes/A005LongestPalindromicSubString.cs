namespace LeetCodes
{
    public class A005LongestPalindromicSubString
    {
        [Solution(IsSolution = true)]
        public string LongestPalindrome(string s) {
            
            bool[][] matrix = new bool[s.Length][];
            int startIndex = 0, maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                matrix[i] = new bool[s.Length];
                for (int j = 0; j < s.Length; j++)
                {
                    matrix[i][j] = false;
                }

                matrix[i][i] = true;
            }
            

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    matrix[i][i + 1] = true;
                    startIndex = i;
                    maxLength = 2;
                }
            }

            for (int len = 3; len <= s.Length; len++)
            {
                for (int i = 0; i < s.Length - len - 1; i++)
                {
                    var j = i + len - 1;
                    if (s[i] == s[j] && matrix[i + 1][j - 1] == true)
                    {
                        matrix[i][j] = true;
                        maxLength = len;
                        startIndex = i;
                    }
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}