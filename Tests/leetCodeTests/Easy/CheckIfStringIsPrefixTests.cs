using LeetCode.Easy;

public class CheckIfStringIsPrefixTests
{
    [Fact]
    public void CheckIfStringIsPrefixTest1()
    {
        var s = "iloveleetcode";
        var words = new string[] { "i", "love", "leetcode", "apples" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest2()
    {
        var s = "iloveleetcode";
        var words = new string[] { "apples", "i", "love", "leetcode" };
        var expected = false;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest3()
    {
        var s = "a";
        var words = new string[] { "aa", "aaaa", "banana" };
        var expected = false;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest4()
    {
        var s = "ccccccccc";
        var words = new string[] { "c", "cc" };
        var expected = false;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest5()
    {
        var s = "a";
        var words = new string[] { "a", "aa", "aaaa" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest6()
    {
        var s = "a";
        var words = new string[] { "a", "aa", "aaaa" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest7()
    {
        var s = "a";
        var words = new string[] { "a", "aa", "aaaa" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest8()
    {
        var s = "a";
        var words = new string[] { "a", "aa", "aaaa" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckIfStringIsPrefixTest9()
    {
        var s = "a";
        var words = new string[] { "a", "aa", "aaaa" };
        var expected = true;
        var actual = new CheckIfStringIsPrefixSolution().IsPrefixString(s, words);
        Assert.Equal(expected, actual);
    }
}
