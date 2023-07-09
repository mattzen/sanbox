from recursion import *
from dog import *
from other_problems import *
from majority_element import *
from typing import List
import re


def swapPositions(list, pos1, pos2):
    list[pos1], list[pos2] = list[pos2], list[pos1]
    return list

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right   
        
    #def maxDepth(self, root: Optional[TreeNode]) -> int:
     #   return 1

def sliding_window(elements, window_size):   
    if len(elements) <= window_size:
       return elements
    for i in range(len(elements)):
        print(elements[i:i+window_size])  
        

def smallest_length(elements, k):
    if(len(elements)< 3):
        return -1   
    head = 0
    rear = 1
    min_length = -1
    current_sum = elements[head] + elements[rear]
    while(rear < len(elements)):
        while(current_sum != k):
        
            if(min_length > rear - head + 1):
                min_length = rear - head + 1
        
            
            
    return min_length
            

if __name__ == "__main__":
    #print(SumOfDigits(123456767))
    #print(SumofDigitsIterative(123456767))
    #print(Solution.majorityElement3([1,3,2,2,2,2]))
    #sol = Solution()
    #print(sol.removeElement2([3,2,2,3], 3))
    #print(is_palindrome("aSmanaplanacanalpanama"))
    #print(is_palindrome("A man, a plan, a canal: Panama"))
    #print(is_palindrome("ab_a"))
    #print(lengthOfLastWord("   fly me   to   the moon  "))
    #print(reverseWords("the sky is blue"))
    #print(strStr("leetcode", "leeto"))
    #print(strStr("sdbutsad", "sad"))
    #sliding_window([1,2,3,4,5,6,7,8], 3)
    #d = Dog("Kensai", 10)
    #print(d.breed)
    print(smallest_length([2,3,1,2,4,3], 7))