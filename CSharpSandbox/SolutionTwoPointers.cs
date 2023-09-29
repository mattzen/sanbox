using System;
using System.Dynamic;
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


        public int MinMutation(string start, string end, string[] bank)
        {
            Queue<string> q = new();
            HashSet<string> used = new();

            q.Enqueue(start);
            used.Add(start);

            int t = 0;
            bool reachedEnd = false;
            while (q.Count > 0 && !reachedEnd)
            {
                int iterationCount = q.Count;

                for (int i = 0; i < iterationCount && !reachedEnd; i++)
                {
                    string c = q.Dequeue();

                    for (int j = 0; j < bank.Length && !reachedEnd; j++)
                    {
                        if (used.Contains(bank[j])) continue;

                        int diffs = 0;
                        for (int k = 0; k < 8 && diffs <= 1; k++)
                        {
                            if (c[k] != bank[j][k]) diffs++;
                        }

                        if (diffs == 1)
                        {
                            if (bank[j] == end) reachedEnd = true;
                            else
                            {
                                q.Enqueue(bank[j]);
                                used.Add(bank[j]);
                            }
                        }
                    }
                }

                t++;
            }

            if (!reachedEnd) return -1;
            return t;
        }

         public int MinMutationMy(string start, string end, string[] bank)
         {
            





            return -1;
         }
    }
}