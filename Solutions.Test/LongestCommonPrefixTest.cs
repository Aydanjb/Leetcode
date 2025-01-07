using JetBrains.Annotations;
using Solutions;

namespace Solutions.Test;

[TestSubject(typeof(Solution14))]
public class LongestCommonPrefixTest
{

    [Fact]
    public void TestLongestCommonPrefixExample1()
    {
        var solution = new Solution14();
        string expected = "fl";
        string actual = solution.LongestCommonPrefix(["flower", "flow", "flight"]);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestLongestCommonPrefixExample2()
    {
        var solution = new Solution14();
        string expected = "";
        string actual = solution.LongestCommonPrefix(["dog", "racecar", "car"]);
        
        Assert.Equal(expected, actual);
    }
}