namespace LeetCodes
{
    public class A036ValidSudoku
    {
        public bool IsValidSudoku(char[,] board) 
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var ch = board[i,j];
                    if (ch == '.')
                    {
                        continue;
                    }
                    for (int k = 0; k < 9; k++)
                    {
                        if (k != j && board[i, k] == ch)
                        {
                            return false;
                        }
                    }

                    for (int k = 0; k < 9; k++)
                    {
                        if (k != i && board[k, j] == ch)
                        {
                            return false;
                        }
                    }

                    if (!CheckSmallCube(board, i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool CheckSmallCube(char[,] board, int i, int j)
        {
            for (int xstart = (i / 3) * 3; xstart < (i / 3) * 3 + 3; xstart++)
            {
                for (int ystart = (j / 3) * 3; ystart < (j / 3) * 3 + 3; ystart++)
                {
                    if (xstart == i && ystart == j)
                    {
                        continue;
                    }

                    if (board[xstart, ystart] == board[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}