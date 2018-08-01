using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    
    public class A039CombinationSum
    {
        [Solution(IsSolution = true)]
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var sorted = candidates.OrderBy(a => a).ToArray();
            IList<IList<int>> res = new List<IList<int>>();
            Stack<int> currentPath = new Stack<int>();
            
            DFS(sorted, 0, target, ref currentPath, ref res);

            return res;
        }

        public void DFS(int[] candidates, int start, int target, ref Stack<int> currentPath, ref IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(currentPath.Reverse().ToList());
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i] <= target)
                {
                    currentPath.Push(candidates[i]);
                    DFS(candidates, i, target - candidates[i], ref currentPath, ref result);
                    currentPath.Pop();
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}