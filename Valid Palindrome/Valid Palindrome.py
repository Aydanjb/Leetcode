def isPalindrome(s: str) -> bool:
        s = s.casefold()
        s = "".join(c for c in s if c.isalnum())
        left, right = 0, len(s) - 1
        while (left < right):
            if (s[left] != s[right]):
                return False
            if (s[left] == s[right]):
                left += 1
                right -= 1
        return True

# Time Complexity: O(n)
# Space Complexity: O(1)