using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;

namespace LeetCodes
{
    public class A015ThreeSum
    {
        
        [Solution(IsSolution = true)]
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var ans = new HashSet<IList<int>>(new MyComparer());
            if (nums.Length == 3 && nums[0] + nums[1] + nums[2] == 0)
            {
                ans.Add(nums);
                return ans.ToList();
            }

            var sortedNums = nums.OrderBy(a => a).ToList();
            for (var i = 0; i < sortedNums.Count - 2; i++)
            {
                var j = i + 1;
                var k = sortedNums.Count - 1;

                while (j < k)
                {
                    if (sortedNums[i] + sortedNums[j] + sortedNums[k] == 0)
                    {
                            ans.Add(
                                new List<int>
                                {
                                    sortedNums[i],
                                    sortedNums[j],
                                    sortedNums[k]
                                });
                        j++;
                        k--;
                    }
                    else if (sortedNums[i] + sortedNums[j] + sortedNums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            var sorted = ans.OrderBy(a => a[0]).ThenBy(a => a[1]).ThenBy(a => a[2]);
            return sorted.ToList();
        }
        
        public class MyComparer : IEqualityComparer<IList<int>>
        {
            public bool Equals(IList<int> x, IList<int> y)
            {
                return x[0] == y[0] && x[1] == y[0] && x[2] == y[2];
            }

            public int GetHashCode(IList<int> obj)
            {
                int result = 0;
                for (int i = 0; i < 3; i++)
                {
                    result += (int)Math.Pow(obj[i], 3);
                }

                return result;
            }
        }
    }

    
}