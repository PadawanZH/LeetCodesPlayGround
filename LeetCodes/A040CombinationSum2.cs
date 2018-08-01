using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    public class A040CombinationSum2
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var sorted = candidates.OrderBy(a => a).ToArray();
            Stack<int> curPath = new Stack<int>();
            IList<IList<int>> res = new List<IList<int>>();
            DFS(sorted, 0, target, ref curPath, ref res);
            var set = res.ToHashSet().ToList();
            return set;
        }

        public void DFS(int[] candidates, int start, int target, ref Stack<int> curPath, ref IList<IList<int>> res)
        {
            if (target == 0)
            {
                foreach (var solution in res)
                {
                    if (CheckDuplicate(solution.ToArray(), curPath.Reverse().ToArray()))
                    {
                        return;
                    }
                }
                res.Add(curPath.Reverse().ToList());
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i] <= target)
                {
                    curPath.Push(candidates[i]);
                    DFS(candidates, i + 1, target - candidates[i], ref curPath, ref res);
                    curPath.Pop();
                }
            }
        }

        public bool CheckDuplicate(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }
    }
}