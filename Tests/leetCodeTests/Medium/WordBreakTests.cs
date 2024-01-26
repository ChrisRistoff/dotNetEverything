using LeetCode.Medium;

public class WordBreakTests
{
    private readonly WordBreakSolution _solution = new();

    [Fact]
    public void WordBreakTest1()
    {
        var s = "leetcode";
        var wordDict = new[] {"leet", "code"};
        var expected = true;
        var actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest2()
    {
        var s = "applepenapple";
        var wordDict = new[] {"apple", "pen"};
        var expected = true;
        var actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest3()
    {
        var s = "catsandog";
        var wordDict = new[] {"cats", "dog", "sand", "and", "cat"};
        var expected = false;
        var actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest4()
    {
        string s = "catsandog";
        List<string> wordDict = new() {"cats", "dog", "sand", "and", "cat"};
        bool expected = false;
        bool actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest5()
    {
        string s = "catsandog";
        List<string> wordDict = new() {"cats", "dog", "sand", "and", "cat"};
        var expected = false;
        var actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest6()
    {
        string s = "a";
        List<string> wordDict = new() { "a" };
        bool expected = true;
        bool actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest7()
    {
        string s = "ab";
        List<string> wordDict = new() { "a", "b" };
        bool expected = true;
        bool actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordBreakTest8()
    {
        string s = "bb";
        List<string> wordDict = new List<string>() { "a", "b", "bbb", "bbbb" };
        bool expected = true;
        bool actual = _solution.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }
}
