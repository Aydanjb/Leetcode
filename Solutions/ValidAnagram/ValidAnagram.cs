namespace Solutions.ValidAnagram;

// Source: https://leetcode.com/problems/valid-anagram
// Author: Aydan Bondurant
// Date: 2026-11-20

// Leetcode 242. Valid Anagram
// Difficulty: Easy
// Time Complexity: O(n)
// Space Complexity: O(1)
public class Solution
{
    /*  Solution:
     *      1. Iterate over each string
     *      2. For each element in s, increment its index in the frequency array.
     *          Then, for each element in t, decrement its index in the frequency array.
     *          If all elements in the frequency array are 0, then the strings are anagrams.
     *
     *      Alternatively, we could use two dictionaries and compare the frequencies of each character in both strings.
     *          This would solve the follow-up question where inputs contain Unicode characters.
     *
     *      Lastly, we could sort both strings and use parallel pointers to determine equality.
     */
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var freq = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        return freq.All(n => n == 0);
    }
}