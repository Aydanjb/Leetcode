namespace Solutions.Test;

public class ContainsDuplicateTest
{
    public static IEnumerable<object[]> DuplicateArrays => new List<object[]>
    {
        new object[] { new int[] {1, 2, 3, 1} },
        new object[] { new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2} }
    };

    public static IEnumerable<object[]> ArraysWithoutDuplicates => new List<object[]>
    {
        new object[] { new int[] { 1, 2, 3, 4 } },
        new object[] { new int[] { 5, 4, 6 } }
    };
    
    [Theory]
    [MemberData(nameof(DuplicateArrays))]
    public void TestContainsDuplicate1(int[] arr)
    {
        var solution = new Solution217();
        Assert.True(solution.ContainsDuplicate(arr));
    }

    [Theory]
    [MemberData(nameof(ArraysWithoutDuplicates))]
    public void TestContainsDuplicate2(int[] arr)
    {
        var solution = new Solution217();
        Assert.False(solution.ContainsDuplicate(arr));
    }
}