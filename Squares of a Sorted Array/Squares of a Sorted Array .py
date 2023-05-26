def squareArray(nums):
    n = len(nums)
    squares = [0] * n
    largestIndex = n - 1
    l, r = 0, n - 1
    while l <= r:
        lSquare, rSquare = nums[l] ** 2, nums[r] ** 2
        if lSquare > rSquare:
            squares[largestIndex] = lSquare
            l += 1
        else:
            squares[largestIndex] = rSquare
            r -= 1
        largestIndex -= 1
    return squares

# Time Complexity: O(n)
# Space Complexity: O(1)