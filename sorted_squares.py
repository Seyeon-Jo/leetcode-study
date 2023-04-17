# Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

# Example 1:

# - Input: nums = [-4,-1,0,3,10]
# - Output: [0,1,9,16,100]
# - Explanation: After squaring, the array becomes [16,1,0,9,100]. After sorting, it becomes [0,1,9,16,100].

# Example 2:

# - Input: nums = [-7,-3,2,3,11]
# - Output: [4,9,9,49,121]

# Constraints:

# 1 <= nums.length <= 10<sup>4</sup>
# -10<sup>4</sup> <= nums[i] <= 10<sup>4</sup>
# nums is sorted in non-decreasing order.

# Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?


class Solution:
    def sorted_squares(self, nums):
        result = []
        for num in nums:
            result.append(num * num)
        result.sort()
        return result


"""
class Solution:
    def sorted_squares(self, nums: list[int]) -> list[int]:
        n = len(nums)
        result = [0] * n
        left = 0
        right = n - 1

        for i in range(n - 1, -1, -1):
            if abs(nums[left]) < abs(nums[right]):
                square = nums[right]
                right -= 1
            else:
                square = nums[left]
                left += 1
            result[i] = square * square
        return result
"""

solution = Solution()
print(solution.sorted_squares([-4, -1, 0, 3, 10]))
