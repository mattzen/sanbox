from recursion import *
from majority_element import *
from typing import List
import re

class Solution:    
    def removeElement(self, nums: List[int], val: int) -> int:
           # Counter for keeping track of elements other than val
        count = 0
        # Loop through all the elements of the array
        for i in range(len(nums)):
            if nums[i] != val:
                # If the element is not val
                nums[count] = nums[i]
                count += 1
        return count
    
    def removeElement2(self, nums: List[int], val: int) -> int:
            while val in nums:
                nums.remove(val)
    
    def swapPositions(self, list, pos1, pos2):
        list[pos1], list[pos2] = list[pos2], list[pos1]
        return list
class SolutionProfit:
    def maxProfit(self, prices: List[int]) -> int:
        current_stock = prices[0]
        profit = 0
        for i in range(1, len(prices)):
            if(current_stock > prices[i]):
                current_stock = prices[i]
            if(prices[i] - current_stock > profit):
                profit = prices[i] - current_stock
        return profit

def is_palindrome(x : str) -> bool :
    x = x.lower()
    x = re.sub(r'\W+', '', x)
    x = x.replace("_", "")
    front = 0
    if(len(x) == 0):
        return True
    rear = len(x) - 1
    is_palindrome = False
    while x[front] == x[rear]:
        if(front == rear):
            is_palindrome = True
            break
        if(len(x) % 2 == 0 and front + 1 == rear):
            is_palindrome = True
            break
        front += 1
        rear -=1
    return is_palindrome
 
def lengthOfLastWord(s: str) -> int: 
    result = re.findall(r"\w+", s)
    return len(result[-1])
    
def canJump(nums: List[int]) -> bool:
    ctr = 0

    while(ctr + nums[ctr] <= len(nums)):
            if(ctr + nums[ctr] == len(nums) - 1):
                return True
            if(len(nums) == 1):
                return True
            if(ctr + 1 > len(nums) -1):
                return True
            ctr +=1
    return False

def reverseWords(s: str) -> str:
    result = re.findall(r"\w+", s)
    last_index = len(result) - 1
    final_sentence = result[last_index]
    while(last_index > 0):
        last_index -= 1
        final_sentence += " " + result[last_index]
    return final_sentence
    
if __name__ == "__main__":
    #print(SumOfDigits(123456767))
    #print(SumofDigitsIterative(123456767))
    #print(Solution.majorityElement3([1,3,2,2,2,2]))
    #sol = Solution()
    #print(sol.removeElement2([3,2,2,3], 3))
    #print(is_palindrome("amanaplanacanalpanama"))
    #print(is_palindrome("A man, a plan, a canal: Panama"))
    #print(is_palindrome("ab_a"))
    #print(lengthOfLastWord("   fly me   to   the moon  "))
    print(reverseWords("the sky is blue"))