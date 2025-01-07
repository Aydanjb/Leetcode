using JetBrains.Annotations;
using FluentAssertions;

namespace Solutions.Test;

[TestSubject(typeof(Solution49))]
public class GroupAnagramsTest
{

    [Fact]
    public void TestGroupAnagramsExample1()
    {
        var solution = new Solution49();
        IList<IList<string>> expected = [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]];
        var actual = solution.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
        
        expected.Select(inner => inner.OrderBy(x => x).ToList())
            .Should().BeEquivalentTo(actual.Select(inner => inner.OrderBy(x => x).ToList()));
    }
}