namespace Solutions;

public class Solution217
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (!freqMap.TryAdd(n, 1))
            {
                freqMap[n] += 1;
            }
        }

        foreach (var key in freqMap)
        {
            if (key.Value > 1)
            {
                return true;
            }
        }

        return false;
    }
}