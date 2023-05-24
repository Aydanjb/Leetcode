def reverseVowels(s: str) -> str:
  vowels = "aeiouAEIOU"
  chars = list(s)
  l, r = 0, len(s) - 1
  while l < r:
    if chars[l] in vowels:
      if chars[r] in vowels:
        chars[l], chars[r] = chars[r], chars[l]
        l, r = l + 1, r - 1
      else:
        r -= 1
    else:
      l += 1
  return ''.join(chars)

# Time Complexity: O(n)
# Space Complexity: O(n)