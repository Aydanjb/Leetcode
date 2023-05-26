def squareArray(arr):
    squares = [x ** 2 for x in arr]
    return sorted(squares)

# Time Complexity: O(n^2 log n)
# Space Complexity: O(n)