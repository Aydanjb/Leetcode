def isPangram(string) -> bool:
  set1 = set()  
  for i in string:
    set1.add(i)
  if len(set1) == 26:
    return True
  return False

# Time Complexity: O(n)
# Space Complexity: O(n)