"""
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

- Input: nums = [0,1,0,3,12]
- Output: [1,3,12,0,0]

Example 2:

- Input: nums = [0]
- Output: [0]

Constraints:

- 1 <= nums.length <= 10^4
- -2^31 <= nums[i] <= 2^31 - 1

Follow up: Could you minimize the total number of operations done?

Hint #1:

In-place means we should not be allocating any space for extra array. But we are allowed to modify the existing array. However, as a first step, try coming up with a solution that makes use of additional space. For this problem as well, first apply the idea discussed using an additional array and the in-place solution will pop up eventually.

Hint #2:

A two-pointer approach could be helpful here. The idea would be to have one pointer for iterating the array and another pointer that just works on the non-zero elements of the array.



def moveZeroes(nums: list[int]) -> None:
    n = len(nums)

    # Count the zeroes
    numZeroes = 0
    for i in range(n):
        numZeroes += nums[i] == 0
        # nums[i] == 0 의 결과가 참이면 numZeroes 변수에 1을 더함

    # Make all the non-zero elements retain their original order.
    ans = []
    for i in range(n):
        if nums[i] != 0:
            ans.append(nums[i])

    # Move all zeroes to the end
    while numZeroes > 0:
        ans.append(0)
        numZeroes -= 1

    # Combine the result
    for i in range(n):
        nums[i] = ans[i]



def moveZeroes(nums: list[int]) -> None:
    lastNonZeroFoundAt = 0
    for i in range(len(nums)):
        if nums[i] != 0:
            nums[lastNonZeroFoundAt] = nums[i]
            lastNonZeroFoundAt += 1

    for i in range(lastNonZeroFoundAt, len(nums)):
        nums[i] = 0
"""


def moveZeroes(nums: list[int]) -> None:
    lastNonZeroFoundAt = 0
    for cur in range(len(nums)):
        if nums[cur] != 0:
            nums[lastNonZeroFoundAt], nums[cur] = nums[cur], nums[lastNonZeroFoundAt]
            lastNonZeroFoundAt += 1


nums = [0, 1, 0, 3, 12]
moveZeroes(nums)
print(nums)
