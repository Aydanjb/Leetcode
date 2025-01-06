using JetBrains.Annotations;

namespace Solutions.Test;

[TestSubject(typeof(Solution1929))]
public class ConcatenationOfArrayTest
{
    [Fact]
    public void TestConcatenatesExample1()
    {
        var solution = new Solution1929();
        int[] expected = { 1, 2, 1, 1, 2, 1 };
        int[] actual = solution.GetConcatenation([1, 2, 1]);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestConcatenatesExample2()
    {
        var solution = new Solution1929();
        int[] expected = { 1, 3, 2, 1, 1, 3, 2, 1 };
        int[] actual = solution.GetConcatenation([1, 3, 2, 1]);
        
        Assert.Equal(expected, actual);
    }
}