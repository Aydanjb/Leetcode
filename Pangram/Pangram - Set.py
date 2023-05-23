def isPangram(string) -> bool:
  string = string.lower()
  set1 = set()  
  for i in string:
    if i in set1:
      pass
    set1.add(i)
  if len(set1) == 26:
    return True
  return False

# Time Complexity: O(n)
# Space Complexity: O(n)