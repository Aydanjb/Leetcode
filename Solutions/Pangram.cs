namespace Solutions;

// Time Complexity: O(n)
// Space Complexity: O(n)
// n: Size of input string
public class Solution1832
{
    public bool CheckIfPangram(string sentence)
    {
        // Create a hashset to keep track of characters we've seen
        HashSet<char> characters = new HashSet<char>();

        // Add each character to the hashset
        foreach (char c in sentence)
        {
            characters.Add(c);
        }

        // If the sentence contains all 26 letters, it is a pangram
        return characters.Count == 26;
    }
}