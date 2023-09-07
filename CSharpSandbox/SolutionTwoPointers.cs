using System;
namespace CSharpSandbox
{
    public class SolutionTwoPointers
    {
        public int MaxAreaTLE(int[] height)
        {
            var result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int leftHeight = height[i];
                for (int j = i + 1; j < height.Length; j++)
                {
                    int rightHeight = height[j];
                    int currentResult;

                    if (leftHeight <= rightHeight)
                    {
                        currentResult = leftHeight * (j - i);
                    }
                    else
                    {
                        currentResult = rightHeight * (j - i);
                    }

                    if (result < currentResult)
                    {
                        result = currentResult;
                    }

                }
            }
            return result;
        }

        public int MaxArea(int[] height)
        {
            var result = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {

                int rightHeight = height[j];
                int currentResult;
                int leftHeight = height[i];

                if (leftHeight <= rightHeight)
                {
                    currentResult = leftHeight * (j - i);
                }
                else
                {
                    currentResult = rightHeight * (j - i);
                }

                if (result < currentResult)
                {
                    result = currentResult;
                }
                if (leftHeight < rightHeight)
                {
                    i++;
                }
                if (rightHeight <= leftHeight)
                {
                    j--;
                }

            }
            return result;
        }
    }
}