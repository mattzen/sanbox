using System;
using System.Security.Cryptography;
using System.Xml.XPath;
namespace CSharpSandbox
{

class Solution {
    public int SolutionSmallestInteger(int[] A) {
        // Determine the smallest positive integer that is missing
        // For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
        // Given A = [1, 2, 3], the function should return 4.
        // Given A = [−1, −3], the function should return 1.

        // Write an efficient algorithm for the following assumptions:
        // N is an integer within the range [1..100,000];
        // each element of array A is an integer within the range [−1,000,000..1,000,000].

        var min = 1;
        var hashset = new HashSet<int>();
        for(int i=0; i< A.Length; i++){
            hashset.Add(A[i]);
        }

        while(hashset.Contains(min)){
            min++;
        }

        return min;
    }
}



    public class Solutions
    {
        public int LargestAltitude(int[] gain)
        {
            
            var highest = 0;
            var previous = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                if ((gain[i] - previous) > highest)
                {
                    highest = gain[i] - previous;
                }
                previous = previous - gain[i];
            }
            return highest;
        }

        #region 1657. Determine if Two Strings Are Close

        // Two strings are considered close if you can attain one from the other
        // using the following operations:

        // Operation 1: Swap any two existing characters.
        // For example, abcde -> aecdb
        // Operation 2: Transform every occurrence of one existing character
        // into another existing character, and do the same with the other character.
        // For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
        // You can use the operations on either string as many times as necessary.

        // Given two strings, word1 and word2, return true if word1 and word2 are close, and
        // false otherwise.

        // Example 1:

        // Input: word1 = "abc", word2 = "bca"
        // Output: true
        // Explanation: You can attain word2 from word1 in 2 operations.
        // Apply Operation 1: "abc" -> "acb"
        // Apply Operation 1: "acb" -> "bca"
        // Example 2:

        // Input: word1 = "a", word2 = "aa"
        // Output: false
        // Explanation: It is impossible to attain word2 from word1, or vice versa, 
        // in any number of operations.
        // Example 3:

        // Input: word1 = "cabbba", word2 = "abbccc"
        // Output: true
        // Explanation: You can attain word2 from word1 in 3 operations.
        // Apply Operation 1: "cabbba" -> "caabbb"
        // Apply Operation 2: "caabbb" -> "baaccc"
        // Apply Operation 2: "baaccc" -> "abbccc"
        #endregion
        public bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length){
                return false;
            }
            HashSet<char> set1 = new HashSet<char>();
            HashSet<char> set2 = new HashSet<char>();
            List<int> set1C = new List<int>();
            List<int> set2C = new List<int>();
            for (int i = 0; i < word1.Length; i++)
            {
                set1.Add(word1[i]);
                set2.Add(word2[i]);
            }
            var res = set1.SetEquals(set2);
            return res;
        }
    }
}
