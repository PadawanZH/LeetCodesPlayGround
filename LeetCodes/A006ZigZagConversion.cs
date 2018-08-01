namespace LeetCodes
{
    public class A006ZigZagConversion
    {
        [Solution(IsSolution = true)]
        public string Convert(string s, int numRows) {

            if (numRows == 1)
            {
                return s;
            }
            
            char[] res = new char[s.Length];
            
            int index = 0;
            
            for (int i = 0; i < numRows; i++)
            {
                var indexInOrigin = i;
                bool down = (i != numRows - 1);
                
                while (indexInOrigin < s.Length)
                {
                    res[index++] = s[indexInOrigin];
                    if (down)
                    {
                        indexInOrigin += 2 * (numRows - i - 1);
                        if (i != 0)
                        {
                            down = false;
                        }
                    }
                    else
                    {
                        indexInOrigin += 2 * i;
                        if (i != numRows - 1)
                        {
                            down = true;
                        }
                    }
                }    
            }

            return new string(res);
        }
    }
}