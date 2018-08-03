namespace LeetCodes
{
    public class A043WildcardMatching
    {
        [Solution(IsSolution = true)]
        public bool IsMatch(string s, string p)
        {
            if (s == null && p == null) return false;
            //i as first i in s, j as first j in p
            bool[,] m = new bool[s.Length + 1, p.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    m[i, j] = false;
                }
            }

            //0 length str match 0 length pattern
            m[0, 0] = true;

            //first col, don't match anything if pattern is empty
            for (int i = 1; i <= s.Length; i++)
            {
                m[i, 0] = false;
            }
            
            //first row, only match n column if leading n *
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '*')
                {
                    m[0, j] = true;
                }
                else
                {
                    break;
                }
            }
            
            //start
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (p[j-1] == '*')
                    {
                        if (m[i - 1, j] == true || m[i, j - 1] == true)
                        {
                            m[i, j] = true;
                        }
                    }
                    else if (p[j-1] == '?' && m[i-1, j-1] == true)
                    {
                        m[i, j] = true;
                    }
                    else
                    {
                        if (m[i - 1, j - 1] == true && s[i-1] == p[j-1])
                        {
                            m[i, j] = true;
                        }
                    }
                }
            }

            return m[s.Length, p.Length];
        }
    }
}