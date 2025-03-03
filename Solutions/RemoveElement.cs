namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(1)
// n: Size of input array
public class Solution27
{
    public int RemoveElement(ref int[] nums, int val)
    {
        // Use a pointer to keep track of the position of elements we want to remove
        var k = 0;
        
        // Iterate through the input array
        for (var i = 0; i < nums.Length; i++)
        {
            // If an element is not equal to the target value,
            if (nums[i] != val)
            {
                // remove an occurence of val by overwriting it with the current element
                nums[k] = nums[i];
                
                // Increment k 
                k += 1;
            }
        }
    
        // Return the number of elements remaining
        return k;
    }
}