using JetBrains.Annotations;
using Solutions;

namespace Solutions.Test;

[TestSubject(typeof(Solution1))]
public class TwoSumTest
{

    [Fact]
    public void TestTwoSumExample1()
    {
        var solution = new Solution1();
        int[] expected = [0, 1];
        int[] actual = solution.TwoSum([2, 7, 11, 15], 9);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestTwoSumExample2()
    {
        var solution = new Solution1();
        int[] expected = [1, 2];
        int[] actual = solution.TwoSum([3, 2, 4], 6);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestTwoSumExample3()
    {
        var solution = new Solution1();
        int[] expected = [0, 1];
        int[] actual = solution.TwoSum([3, 3], 6);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestTwoSumEdgeCase1()
    {
        var solution = new Solution1();
        int[] expected = [2, 4];
        int[] actual = solution.TwoSum([-1, -2, -3, -4, -5], -8);
        
        Assert.Equal(expected, actual);
    }
}