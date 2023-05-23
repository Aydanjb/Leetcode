def containsDuplicate(nums) -> bool:
  for i in range(0, len(nums)):
    for j in range(i + 1, len(nums)):
      if nums[j] == nums[i]:
        return True
  return False

# Time Complexity: O(n^2)
# Space Complexity: O(1)