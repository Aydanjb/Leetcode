import math

def sqrt(n) -> int:
    for i in range(0, n):
        if (i ** 2) == n:
            return i
        if (i ** 2) > n:
            return i - 1
        
# Time Complexity: O(sqrt(n))
# Space Complexity: O(1)