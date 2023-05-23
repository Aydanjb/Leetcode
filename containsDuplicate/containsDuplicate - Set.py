def containsDuplicate(nums) -> bool:
  set1 = set()  
  for i in nums:
    if i in set1:
      return True
    set1.add(i)
  return False

# Time Complexity: O(n)
# Space Complexity: O(n)