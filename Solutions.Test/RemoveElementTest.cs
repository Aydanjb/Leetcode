using JetBrains.Annotations;
using Solutions;

namespace Solutions.Test;

[TestSubject(typeof(Solution27))]
public class RemoveElementTest
{

    [Fact]
    public void TestRemoveElementExample1()
    {
        var solution = new Solution27();
        int[] nums = [3, 2, 2, 3];
        int expected = 2;
        int actual = solution.RemoveElement(ref nums, 3);
        
        Assert.Equal(expected, actual);
    }
}