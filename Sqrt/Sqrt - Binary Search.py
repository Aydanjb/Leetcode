def sqrt(n) -> int:
    l = 0
    r = n

    if n < 2: 
        return n
    
    while l <= r:
      m = l + (r - l) // 2
      if (m ** 2) > n:
          r = m - 1
      elif (m ** 2) < n:
          l = m + 1
      else:
          return m
    return r
      
# Time Complexity: O(log(n))
# Space Complexity: O(1)