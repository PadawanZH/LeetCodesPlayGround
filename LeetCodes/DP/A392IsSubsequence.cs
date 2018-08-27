namespace LeetCodes
{
    public class A392IsSubsequence
    {
        [Solution(IsSolution = true)]
        public bool IsSubsequence(string s, string t)
        {
            if (t == null || s == null || t.Length < s.Length)
            {
                return false;
            }

            if (t.Length >= 0 && s.Length == 0)
            {
                return true;
            }

            int tIndex = 0;
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                flag = false;
                while (tIndex < t.Length)
                {
                    if (s[i] == t[tIndex])
                    {
                        tIndex++;
                        flag = true;
                        break;
                    }

                    tIndex++;
                }

                if (tIndex == t.Length && !flag)
                {
                    return false;
                }
            }

            return true;
        }
    }
}