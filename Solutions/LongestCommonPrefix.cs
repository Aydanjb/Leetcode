using System.Text;

namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(1)
// n: Total number of characters in the input array
public class Solution14
{
    public string LongestCommonPrefix(string[] strs)
    {
        // If the input array in empty, return an empty string.
        if (strs.Length == 0) return "";
        
        // Get the length of the first string.
        int n = strs[0].Length;
        StringBuilder result = new StringBuilder();

        // Iterate through each character in the first string.
        for (int i = 0; i < n; i++)
        {
            // Compare the current character with the corresponding character in the other strings.
            foreach (var s in strs)
            {
                // If we reach the end or find a mismatch, return the result.
                if (i == s.Length || s[i] != strs[0][i]) return result.ToString();
            }

            // If all strings have same character at index i, add it to the result.
            result.Append(strs[0][i]);
        }

        return result.ToString();
    }
}