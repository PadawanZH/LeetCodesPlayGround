namespace LeetCodes
{
    public class Strstr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            int[] next = new int[needle.Length];
            GetNext(needle, ref next);

            int commonLen = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                while (commonLen > -1 && needle[commonLen + 1] != haystack[i])
                {
                    commonLen = next[commonLen];
                }

                if (needle[commonLen + 1] == haystack[i])
                {
                    commonLen++;
                }

                if (commonLen == needle.Length - 1)
                {
                    return i - needle.Length + 1;
                }
            }

            return -1;
        }

        public void GetNext(string needle, ref int[] next)
        {
            next[0] = -1;
            int commonLen = -1;

            for (int q = 1; q < needle.Length - 1; q++)
            {
                while (commonLen > -1 && needle[commonLen + 1] != needle[q])
                {
                    commonLen = next[commonLen];
                }

                if (needle[commonLen + 1] == needle[q])
                {
                    commonLen++;
                }

                next[q] = commonLen;
            }
        }
    }
}