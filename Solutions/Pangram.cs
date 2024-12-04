namespace Solutions;

public class Solution1832
{
    public bool CheckIfPangram(string sentence)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        string s = sentence.ToLower();
        foreach (char c in s)
        {
            if (!char.IsLetter(c)) continue;
            alphabet.TryAdd(c, 1);
        }

        if (alphabet.Sum(x => x.Value) < 26) return false;

        return true;
    }
}