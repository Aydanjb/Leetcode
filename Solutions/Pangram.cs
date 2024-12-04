namespace Solutions;

public class Solution1832
{
    public bool CheckIfPangram(string sentence)
    {
        // Create a dictionary to keep track of which letters we've seen.
        Dictionary<char, int> alphabet = new Dictionary<char, int>();

        // Ignore case.
        string s = sentence.ToLower();
        foreach (char c in s)
        {
            // Ignore numbers, symbols, and whitespace.
            if (!char.IsLetter(c)) continue;

            // If the letter is already in our dictionary, ignore it. Otherwise, add it with a value of 1.
            alphabet.TryAdd(c, 1);
        }

        // If there's 26 keys in our dictionary, the sentence is a pangram. Otherwise, return false.
        if (alphabet.Sum(x => x.Value) < 26) return false;

        return true;
    }
}