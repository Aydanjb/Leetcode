namespace Solutions;

public class Solution242
{
    public bool IsAnagram(string s, string t)
    {
        // If s and t are of different lengths, t is not an anagram of s.
        if (s.Length != t.Length) return false;

        // Create a hash map using an array to count the difference in frequency of characters.
        int[] diffs = new int[26];

        // For each character in s, increment frequency.
        // For each character in t, decrement the frequency.
        for (int i = 0; i < s.Length; i++)
        {
            diffs[s[i] - 'a']++;
            diffs[t[i] - 'a']--;
        }

        // If both strings contain exactly the same characters, the array should only contain zeroes.
        foreach (var n in diffs)
        {
            if (n != 0) return false;
        }

        return true;
    }
}