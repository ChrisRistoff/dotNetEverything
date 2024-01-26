using LeetCode.Easy;

namespace Tests.leetCodeTests.Easy;

public class LongestCommonPrefixTests
{
    private readonly LongestCommonPrefixSolution _solution = new();

    [Fact]
    public void LongestCommonPrefixTest1()
    {
        string[] input = ["flower", "flow", "flight"];
        string expected = "fl";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest2()
    {
        string[] input = ["dog", "racecar", "car"];
        string expected = "";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest3()
    {
        string[] input = ["ab", "a"];
        string expected = "a";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest4()
    {
        string[] input = ["a"];
        string expected = "a";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest5()
    {
        string[] input = ["flower", "flower", "flower", "flower"];
        string expected = "flower";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest6()
    {
        string[] input = ["flowser", "flowder", "flowger", "flowzer", "flowers"];
        string expected = "flow";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest7()
    {
        string[] input = ["", "b"];
        string expected = "";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LongestCommonPrefixTest8()
    {
        string[] input = ["", ""];
        string expected = "";
        string actual = _solution.LongestCommonPrefix(input);
        Assert.Equal(expected, actual);
    }
}
