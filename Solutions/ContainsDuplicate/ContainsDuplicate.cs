namespace Solutions.ContainsDuplicate;

// Source: https://leetcode.com/problems/contains-duplicate
// Author: Aydan Bondurant
// Date: 2026-11-19

// Leetcode 217. Contains Duplicate
// Difficulty: Easy
// Time Complexity: O(n)
// Space Complexity: O(n)
public class Solution
{
    /*  Solution:
     *      1. Iterate over the array
     *      2. For each element in nums, try to add it to the HashSet,
     *          if we've already seen it, HashSet.Add() will return `false` and we'll know the array contains a duplicate.
     *
     *      Alternatively, you could sort the array first then check each pair of neighbors.
     *      This approach would improve space complexity to O(1), but worsen time complexity to O(n log n).
     */
    public bool ContainsDuplicate(int[] nums)
    {
        var seen = new HashSet<int>(nums.Length);

        foreach (var n in nums)
            if (!seen.Add(n))
                return true;

        return false;
    }
}