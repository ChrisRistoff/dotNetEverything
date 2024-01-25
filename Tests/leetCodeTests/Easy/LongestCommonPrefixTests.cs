using LeetCode.Easy;

public class LongestCommonPrefixTests
{
    private readonly LongestCommonPrefixSolution _solution = new();

    [Fact]
    public void LongestCommonPrefixTest1()
    {
        var input = new[] {"flower", "flow", "flight"};
        var expected = "fl";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest2()
    {
        var input = new[] {"dog", "racecar", "car"};
        var expected = "";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest3()
    {
        var input = new[] {"ab", "a"};
        var expected = "a";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest4()
    {
        var input = new[] {"a"};
        var expected = "a";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest5()
    {
        var input = new[] {"flower", "flower", "flower", "flower"};
        var expected = "flower";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest6()
    {
        var input = new[] {"flowser", "flowder", "flowger", "flowzer", "flowers"};
        var expected = "flow";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest7()
    {
        var input = new[] {"", "b"};
        var expected = "";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest8()
    {
        var input = new[] {"", ""};
        var expected = "";
        var actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }
}
