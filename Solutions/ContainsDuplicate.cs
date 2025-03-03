namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(n)
// n: Size of input array
public class Solution217
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Use a dictionary to store unique elements
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        // Iterate through the input array
        foreach (var n in nums)
        {
            if (!freqMap.TryAdd(n, 1)) // If we have already seen an element return true
            {
                return true;
            }
        }

        return false;
    }
}