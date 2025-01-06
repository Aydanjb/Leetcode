namespace Solutions;

public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indices = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (indices.TryGetValue(nums[i], out var index)) return [index, i];
            indices.TryAdd(target - nums[i], i);
        }

        return [];
    }
}