def numGoodPairs(nums):
    pairCount = 0
    l = 0
    r = len(nums) - 1

    for l in range(len(nums)):
        while l < r:
            if nums[l] == nums[r]:
                pairCount += 1
            r -= 1
        r = len(nums) - 1
    
    return pairCount

# Time Complexity: O(n^2)
# Space Complexity: O(1)