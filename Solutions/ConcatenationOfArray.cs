namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(n)
// n: Size of input array
public class Solution1929
{
    public int[] GetConcatenation(int[] nums)
    {
        // Get the length of the input array
        int n = nums.Length;
        
        // An array concatenated with itself is twice the size
        int[] result = new int[2 * n];
        
        // Iterate through the input array
        for (int i = 0; i < n; i++)
        {
            // Copy each value into the result array twice
            result[i] = nums[i];
            result[i + n] = nums[i];
        }
        
        return result;
    }
}