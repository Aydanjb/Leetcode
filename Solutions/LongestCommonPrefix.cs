namespace Solutions;

public class Solution14
{
    public string LongestCommonPrefix(string[] strs)
    {
        int n = strs[0].Length;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            foreach (var s in strs)
            {
                if (i == s.Length || s[i] != strs[0][i]) return result;
            }

            result += strs[0][i];
        }

        return result;
    }
}