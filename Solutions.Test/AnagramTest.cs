namespace Solutions.Test;

public class AnagramTest
{
    public static IEnumerable<object[]> IsAnagramTrue => new List<object[]>
    {
        new object[] { new string("anagram"), new string("nagaram") },
        new object[] { new string("abc"), new string("cab") },
    };

    public static IEnumerable<object[]> IsAnagramFalse => new List<object[]>
    {
        new object[] { new string("rat"), new string("car") },
        new object[] { new string("dog"), new string("cat") },
        new object[] { new string("ac"), new string("bb") },
    };

    [Theory]
    [MemberData(nameof(IsAnagramTrue))]
    public void IsAnagramTest(string input, string expected)
    {
        var solution = new Solution242();
        Assert.True(solution.IsAnagram(input, expected));
    }

    [Theory]
    [MemberData(nameof(IsAnagramFalse))]
    public void IsAnagramFalseTest(string input, string expected)
    {
        var solution = new Solution242();
        Assert.False(solution.IsAnagram(input, expected));
    }
}