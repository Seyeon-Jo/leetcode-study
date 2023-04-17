class Solution:
    def duplicateZeros(self, arr: list[int]) -> None:
        """
        Do not return anything, modify arr in-place instead.
        """

        possible_dup = 0
        length_ = len(arr) - 1

        # Find the number of zeros to be duplicated
        for left in range(length_ + 1):
            # Stop when left points beyond the last element in the original list
            # which would be part of the modified list
            if left > length_ - possible_dup:
                break

            # Count the zeros
            if arr[left] == 0:
                # Edge case: This zero can't be duplicated. We have no more space,
                # as left is pointing to the last element which could be included
                if left == length_ - possible_dup:
                    arr[
                        length_
                    ] = 0  # For this zero we just copy it without duplication.
                    length_ -= 1
                    break
                possible_dup += 1

        # Start backwards from the last element which would be part of new list.
        last = length_ - possible_dup

        # Copy zero twice, and non zero once.
        for i in range(last, -1, -1):
            if arr[i] == 0:
                arr[i + possible_dup] = 0
                possible_dup -= 1
                arr[i + possible_dup] = 0
            else:
                arr[i + possible_dup] = arr[i]


arr = [1, 0, 2, 3, 0, 4, 5, 0]
s = Solution()
s.duplicateZeros(arr)
print(arr)
