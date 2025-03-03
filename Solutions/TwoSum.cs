namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(n)
// n: Size of input array
public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Create a hashmap to store the number needed to reach the target as the key,
        // and it's corresponding index as the value.
        Dictionary<int, int> indices = [];
        
        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the current number exists in the dictionary.
            // If it does, it means we've found two numbers that sum to the target, and we return their indices.
            if (indices.TryGetValue(nums[i], out var index)) return [index, i];
            
            // If the current number doesn't exist in the dictionary,
            // store the value needed to form the sum (target - nums[i]) as the key, and the current index i as the value. 
            indices.TryAdd(target - nums[i], i);
        }
        
        return [];
    }
}