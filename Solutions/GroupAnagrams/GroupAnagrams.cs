namespace Solutions.GroupAnagrams;

// Source: https://leetcode.com/problems/group-anagrams
// Author: Aydan Bondurant
// Date: 2026-11-20

// Leetcode 49. Group Anagrams
// Difficulty: Medium
// Time Complexity: O(n * m)
// Space Complexity: O(n * m)
// n = the number of strings in strs, m = max string length
public class Solution {
    /*  Solution:
     *      1. Iterate over the array
     *      2. Count the frequency of characters in each string and create a key from the frequencies.
     *          Anagrams produce identical keys, so strings with the same key go in the same list.
     */
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = [];
        
        foreach (string str in strs)
        {
            char[] count = new char[26];
            foreach (var c in str)
            {
                count[c - 'a']++;
            }
            
            string key = new string(count);
            if (!anagrams.TryGetValue(key, out List<string>? group))
            {
                group = [];
                anagrams[key] = group;
            }
            group.Add(str);
        }

        return new List<IList<string>>(anagrams.Values);
    }
}