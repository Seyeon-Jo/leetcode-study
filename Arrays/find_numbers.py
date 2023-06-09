# Given an array nums of integers, return how many of them contain an even number of digits.

# Example 1:

# - Input: nums = [12,345,2,6,7896]
# - Output: 2
# - Explanation:
#   : - 12 contains 2 digits (even number of digits).
#   : - 345 contains 3 digits (odd number of digits).
#   : - 2 contains 1 digit (odd number of digits).
#   : - 6 contains 1 digit (odd number of digits).
#   : - 7896 contains 4 digits (even number of digits).
#   : - Therefore only 12 and 7896 contain an even number of digits.

# Example 2:

# - Input: nums = [555,901,482,1771]
# - Output: 1
# - Explanation:
#   : - Only 1771 contains an even number of digits.

# Constraints:

# 1 <= nums.length <= 500
# 1 <= nums[i] <= 10<sup>5</sup>

"""
def find_numbers(nums: list[int]) -> int:
    count = 0
    for num in nums:
        digits = 0
        while num > 0:
            digits += 1
            num //= 10
        if digits % 2 == 0:
            count += 1
    return count
"""

""""""
import math


def find_numbers(nums: list[int]) -> int:
    result = 0

    for num in nums:
        # Compute the number of digits of the current number
        num_digits = int(math.log10(num)) + 1

        # Check if the number of digits is even
        if num_digits % 2 == 0:
            result += 1

    return result


nums = [12, 345, 6789, 12345]

print(find_numbers(nums))
