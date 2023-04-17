def find_max_consecutive_ones(nums):
    count = 0
    max_count = 0

    for num in nums:
        if num == 1:
            count += 1
        else:
            max_count = max(max_count, count)
            count = 0

    return max(max_count, count)

nums = [1, 1, 0, 1, 1, 1]
result = find_max_consecutive_ones(nums)
print(result)
