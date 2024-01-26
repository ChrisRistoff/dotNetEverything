using LeetCode.Easy;

namespace Tests.leetCodeTests.Easy;

public class FindFirstOccurenceInStringTests
{
    private readonly FindFirstOccurenceInStringSolution _solution = new();

    [Fact]
    public void FindFirstOccurenceInStringTest1()
    {
        string haystack = "loveleetcode";
        string needle = "leet";
        int expected = 4;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest2()
    {
        string haystack = "aaaaa";
        string needle = "bba";
        int expected = -1;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest3()
    {
        string haystack = "";
        string needle = "";
        int expected = 0;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest4()
    {
        string haystack = "sadbutsad";
        string needle = "sad";
        int expected = 0;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest5()
    {
        string haystack = "a";
        string needle = "a";
        int expected = 0;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest6()
    {
        string haystack = "abc";
        string needle = "c";
        int expected = 2;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindFirstOccurenceInStringTest7()
    {
        string haystack = "aaa";
        string needle = "aaaa";
        int expected = -1;
        int actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }
}
