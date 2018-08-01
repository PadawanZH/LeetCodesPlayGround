using System.Linq;

namespace LeetCodes
{
    public class A042TrappingRain
    {
        [Solution(IsSolution = true)]
        public int Trap(int[] height) {
            if (height.Length <= 1)
            {
                return 0;
            }

            return GetRightHeigherRain(height);
        }

        public int GetRightHeigherRain(int[] height)
        {
            int left = 0, right = 1;

            int rain = 0;

            while (left < height.Length - 1)
            {
                int subContainerRain = 0;
                while (height[right] < height[left])
                {
                    if (right + 1 < height.Length)
                    {
                        subContainerRain += (height[left] - height[right]);
                        right++;
                    }
                    else if (height[right] >= height[left])
                    {
                        subContainerRain += (height[left] - height[right]);
                        break;
                    }
                    else
                    {
                        int[] reverseHeight = new int[right - left + 1];
                        for (int i = 0; i < right - left + 1; i++)
                        {
                            reverseHeight[i] = height[left + i];
                        }

                        reverseHeight = reverseHeight.Reverse().ToArray();

                        subContainerRain = GetRightHeigherRain(reverseHeight);
                        break;
                    }
                }
                
                left = right;
                right = right + 1;
                rain += subContainerRain;
            }

            return rain;
        }
    }
}