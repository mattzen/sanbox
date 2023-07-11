from recursion import *
from dog import *
from other_problems import *
from majority_element import *
from typing import List
import re

def swapPositions(list, pos1, pos2):
    list[pos1], list[pos2] = list[pos2], list[pos1]
    return list

def sliding_window(elements, window_size):   
    if len(elements) <= window_size:
       return elements
    for i in range(len(elements)):
        print(elements[i:i+window_size])  
        

def minSubArrayLen(nums, s):
        head, rear, current_total, min_length = 0 , 0 , 0, len(nums) + 1
        while rear < len(nums):
            current_total += nums[rear]
            rear += 1
            while current_total >= s:
                min_length = min(min_length, rear - head)
                current_total -= nums[head]
                head += 1
        return min_length if min_length != len(nums) + 1 else 0
 
 #ex 23   
def phoneNumbers(digits):
    d = {
            "2" : "abc",
            "3" : "def",
            "4" : "ghi",
            "5" : "jkl",
            "6" : "mno",
            "7" : "pgrs",
            "8" : "tuv",
            "9" : "wxyz"
        }
    
    result = []
    def backtrack(index, curStr):
        if(len(curStr) == len(digits)):
            result.append(curStr)
            return
        for i in d[digits[index]]:
            backtrack(index + 1, curStr + i)
            
    if(digits):
        backtrack(0, "")
    return result
                


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
    #print(minSubArrayLen([2,3,1,2,4,3], 7))
    print(phoneNumbers("23"))
