namespace Medium.Solutions.Solutions
{
    public class ContainerWithMostWater_11
    {
        /* Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
           n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
           Find two lines, which together with x-axis forms a container, such that the container contains the most water.
        */

        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int j = i + 1;
                int startHeight = height[i];
                while (j < height.Length)
                {
                    int finishHeight = height[j];
                    if (finishHeight >= startHeight)
                    {
                        int vertical = startHeight * (j - i);
                        if (vertical > maxArea)
                        {
                            maxArea = vertical;
                        }
                    }
                    else
                    {
                        int vertical = finishHeight * (j - i);
                        if (vertical > maxArea)
                        {
                            maxArea = vertical;
                        }
                    }

                    j++;
                }

            }
            return maxArea;
        }
    }
}
