namespace Solutions.TwoSum;

// Source: https://leetcode.com/problems/two-sum
// Author: Aydan Bondurant
// Date: 2026-11-19

// Leetcode 1. Two Sum
// Difficulty: Easy
// Time Complexity: O(n)
// Space Complexity: O(n)
public class Solution {
    /*  Solution:
     *      1. Iterate over the array
     *      2. For each element in nums, check whether its complement `target - nums[i]`
     *          was already found, if so, return both indices.
     *          Otherwise, add `nums[i] -> i` to the dictionary.
     */
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> complements = [];
    
        for (int i = 0; i < nums.Length; i++)
        {
            if (complements.TryGetValue(nums[i], out var index)) return [index, i];
            complements.TryAdd(target - nums[i], i);
        }

        return [];
    }
}