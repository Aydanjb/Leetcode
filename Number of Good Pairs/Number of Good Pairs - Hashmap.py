def numGoodPairs(nums):
    pairCount = 0
    freq = {}
    
    for i in nums:
        freq[i] = freq.get(i, 0) + 1
        pairCount += freq[i] - 1
    return pairCount

# Time Complexity: O(n)
# Space Complexity: O(n)