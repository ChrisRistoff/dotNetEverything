namespace Tests.leetCodeTests.Easy;

public class CheckIfStringIsPrefixTests
{
    private readonly CheckIfStringIsPrefixSolution _solution = new();

    [Fact]
    public void CheckIfStringIsPrefixTest1()
    {
        string s = "iloveleetcode";
        string[] words = new string[] { "i", "love", "leetcode", "apples" };
        bool expected = true;
        bool actual = _solution.IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest2()
    {
        string s = "iloveleetcode";
        string[] words = new string[] { "apples", "i", "love", "leetcode" };
        bool expected = false;
        bool actual = _solution.IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest3()
    {
        string s = "a";
        string[] words = new string[] { "aa", "aaaa", "banana" };
        bool expected = false;
        bool actual = _solution.IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest4()
    {
        string s = "ccccccccc";
        string[] words = new string[] { "c", "cc" };
        bool expected = false;
        bool actual = _solution.IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest5()
    {
        string s = "a";
        string[] words = new string[] { "a", "aa", "aaaa" };
        bool expected = true;
        bool actual = _solution.IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }
}
