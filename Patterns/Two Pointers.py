# The Two-pointer pattern is most commonly found in problems involving arrays
# and linked-lists. This is especially true when the problems requires the comparison
# of two or more elements within an array or linked-list.

# Two Sum II example:
# Given a sorted array, find a pair of numbers that sum to a specific number.
# Return value should be index + 1

def findTargetSum(nums, target):
    pointer1 = 0                                # Initalize a pointer at index 0
    pointer2 = len(nums) - 1                    # Initalize a pointer at index n - 1

    while pointer1 < pointer2:                  # Iterate through the array till the pointers meet
        sum = nums[pointer1] + nums[pointer2]   # Find the sum of the elements at both pointers
        if sum == target:                       # If the sum is equal to the target,
            return [pointer1 + 1, pointer2 + 1] # return the indexes in an array
        elif sum < target: 
            pointer1 += 1                       # If the sum is less than target, increment pointer1
        else:
            pointer2 -= 1                       # If the sum is greater than the target, decrement pointer2


    return False                                # If we fail to find a pair that sums to the target, return false

                                                # Time Complexity: O(n)
                                                # Space Complexity: O(1)

print(findTargetSum([2, 3, 4], 6)) # [1, 3] (2 + 4 = 6)