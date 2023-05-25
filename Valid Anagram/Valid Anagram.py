def isAnagram(s, t) -> bool:
  if len(s) != len(t):
    return False

  frequency = {}
  for i in range(len(s)):
    if s[i] in frequency:
      frequency[s[i]] += 1
    else:
      frequency[s[i]] = 1

    if t[i] in frequency:
      frequency[t[i]] -= 1
    else:
      frequency[t[i]] = -1
  
  for char in frequency:
    if frequency[char] != 0:
      return False
  
  return True

# Time Complexity: O(n)
# Space Complexity: O(k)