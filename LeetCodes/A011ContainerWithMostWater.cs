using System;

namespace LeetCodes
{
    public class A011ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int from = 0, to = height.Length - 1;

            int maxArea = 0;
            while (from != to)
            {
                int area = Math.Min(height[from], height[to]) * (to - from);
                maxArea = (maxArea > area) ? maxArea : area;
                if (height[from] > height[to])
                {
                    to--;
                }
                else
                {
                    from++;
                }
            }

            return maxArea;
        }
        
    }
}