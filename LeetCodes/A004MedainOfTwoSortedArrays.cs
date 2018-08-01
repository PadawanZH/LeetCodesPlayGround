using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    public class A004MedainOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int l1 = nums1.Length, l2 = nums2.Length;
            
            
            if (l1 == 0)
            {
                return (l2 == 0)? 0: FindMedian(nums2);
            }
            if (l2 == 0)
            {
                return (l1 == 0)? 0: FindMedian(nums1);
            }

            List<int> sorted = new List<int>();
            
            determinLowerAndUpperBound(nums1, nums2, out int p1, out int upperIn1, out int p2, out int upperIn2);

            while (p1 < upperIn1 || p2 < upperIn2)
            {
                
            }
            
            throw new NotImplementedException();
        }

        public double FindMedian(int[] num)
        {
            if (num.Length % 2 == 0)
            {
                return (num[num.Length / 2] + num[(num.Length / 2) - 1]) / 2.0;
            }
            else
            {
                return num[num.Length / 2];
            }
        }

        public void determinLowerAndUpperBound(int[] nums1, int[] nums2, out int lowerIn1, out int upperIn1, out int lowerIn2, out int upperIn2)
        {
            int[] boundary = new int[4];
            int i = 0;
            boundary[i++] = nums1[nums1.Length / 2];
            boundary[i++] = nums2[nums2.Length / 2];
            if (nums1.Length % 2 == 0)
                boundary[i++] = nums1[nums1.Length / 2 - 1];
            if (nums2.Length % 2 == 0)
                boundary[i++] = nums2[nums2.Length / 2 - 1];

            var ordered = boundary.OrderBy(b => b);
            
            throw new NotImplementedException();
        }
    }
}