from recursion import *
from majority_element import *
from typing import List

class Solution:    
    def removeElement(self, nums: List[int], val: int) -> int:
        self.swapPositions(nums, 0, 1)
        return nums[0]
    
    def swapPositions(self, list, pos1, pos2):
        list[pos1], list[pos2] = list[pos2], list[pos1]
        return list





if __name__ == "__main__":
    #print(SumOfDigits(123456767))
    #print(SumofDigitsIterative(123456767))
    #print(Solution.majorityElement3([1,3,2,2,2,2]))
    sol = Solution()
    print(sol.removeElement([1,2], 2))