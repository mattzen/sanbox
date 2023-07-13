import collections
from typing import List

def SumOfDigits(num : int) -> int:
    num = str(num)
    if len(num) == 1:
        return int(num)
    return int(num[0]) + SumOfDigits(int(num[1:]))
    
def SumofDigitsIterative(num : int) -> int:
    holder = 0
    strNum = str(num)
    for element in strNum:
        holder += int(element)
    return holder

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
       
       
class SolutionStairs:         
    def climbStairsDP(self, n): 
        lookup = {}
        def recursiveStairs(n, index):
            if(index in lookup.keys()):
                return lookup[index]
            if(index == n): 
                return 1
            if(index > n):
                return 0
            for i in range (n):
                lookup[index] = recursiveStairs(n, index + 1) + recursiveStairs(n, index + 2) + recursiveStairs(n, index + 3) + recursiveStairs(n, index + 4)
                return lookup[index]
        return recursiveStairs(n, 0)
    
    def climbStairs(self, n): 
        def recursiveStairs(n, index):
            if(index == n): 
                return 1
            if(index > n):
                return 0
            for i in range (n):
                return recursiveStairs(n, index + 1) + recursiveStairs(n, index + 2)
        return recursiveStairs(n, 0)

        
        
sol = SolutionStairs()
print(sol.climbStairsDP(4))