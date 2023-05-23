def containsDuplicate(nums) -> bool:
  nums = sorted(nums)
  for i in range(0, len(nums) - 1):
    if nums[i] == nums[i + 1]:
      return True
  return False

# Time Complexity: O(n log(n))
# Space Complexity: O(1)