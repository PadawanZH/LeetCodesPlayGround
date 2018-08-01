namespace LeetCodes
{
    public class A014LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            int minLen = int.MaxValue;
            foreach (var str in strs)
            {
                if (minLen > str.Length)
                    minLen = str.Length;
            }

            string res = "";
            for (int i = 0; i < minLen; i++)
            {
                foreach (var str in strs)
                {
                    if (str[i] != strs[0][i])
                    {
                        return res;
                    }
                }

                res += strs[0][i];
            }

            return res;
        }
    }
}