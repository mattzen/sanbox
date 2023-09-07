using System;
namespace CSharpSandbox
{
    public class SolutionSlidingWindow
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var left = 0;
            var right = 0;

            Dictionary<char, bool> lookup = new Dictionary<char, bool>();

            while (right < s.Length)
            {
                if (lookup.ContainsKey(s[right]))
                {
                    while (s[left] != s[right])
                    {
                        lookup.Remove(s[left]);
                        left++;
                    }
                    lookup.Remove(s[left]);
                    left++;
                }

                if (right - left + 1 > result)
                {
                    result = right - left + 1;
                }

                lookup.Add(s[right], true);
                right++;
            }


            return result;
        }
    }


    public class SolutionTwoPointers
    {
        public int MaxArea(int[] height)
        {
            var result = 0;





            return result;
        }
    }




}