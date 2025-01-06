namespace Solutions.Test;

public class PangramTest
{
    public static IEnumerable<object[]> PangramTrueData() => new List<object[]>
    {
        new object[] { new string("The quick brown fox jumps over the lazy dog.") },
        new object[] { new string("ABCDEFGHIJKLMNOPQRSTUVWXYZ") }
    };

    public static IEnumerable<object[]> PangramFalseData() => new List<object[]>
    {
        new object[] { new string("abc") },
        new object[] { new string("123456789") },
        new object[] { new string("") },
    };

    [Theory]
    [MemberData(nameof(PangramTrueData))]

    public void TestPangramTrue(string sentence)
    {
        var solution = new Solution1832();
        Assert.True(solution.CheckIfPangram(sentence));
    }

    [Theory]
    [MemberData(nameof(PangramFalseData))]
    public void TestPangramFalse(string sentence)
    {
        var solution = new Solution1832();
        Assert.False(solution.CheckIfPangram(sentence));
    }
}