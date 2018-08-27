using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace LeetCodes
{
    
    public class A646MaxLengthOfPairChain
    {
        [Solution(IsSolution = true)]
        public int FindLongestChain(int[,] pairs)
        {
            if (pairs == null || pairs.Length == 0 || pairs.GetLength(0) == 0)
            {
                return 0;
            }
            int[][] matrix = new int[pairs.GetLength(0)][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[pairs.GetLength(1)];
                for (int j = 0; j < pairs.GetLength(1); j++)
                {
                    matrix[i][j] = pairs[i, j];
                }
            }

            Array.Sort(matrix, new Comparer());

            int count = 1, lastEnd = matrix[0][1];
            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] > lastEnd)
                {
                    count++;
                    lastEnd = matrix[i][1];
                }
            }
            return count;
        }

        public class Comparer : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x != null && y != null && (x is int[]) && (y is int[]))
                {
                    int[] a = x as int[];
                    int[] b = y as int[];
                    if (a.Length != 2 || b.Length != 2)
                    {
                        throw new Exception();
                    }

                    if (a[1] == b[1])
                    {
                        return 0;
                    }else if (a[1] < b[1])
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                throw new Exception();
            }
        }
    }
}