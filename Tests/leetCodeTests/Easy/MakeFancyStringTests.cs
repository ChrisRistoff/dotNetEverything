namespace Tests.leetCodeTests.Easy;

public class MakeFancyStringTests
{
    private readonly MakeFancyStringSolution _solution = new();

    [Fact]
    public void MakeFancyStringTest1()
    {
        string s = "leeetcode";
        string expected = "leetcode";
        string actual = _solution.MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest2()
    {
        string s = "aaabaaaa";
        string expected = "aabaa";
        string actual = _solution.MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest3()
    {
        string s = "aab";
        string expected = "aab";
        string actual = _solution.MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest4()
    {
        string s = "a";
        string expected = "a";
        string actual = _solution.MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest5()
    {
        string s = "aa";
        string expected = "aa";
        string actual = _solution.MakeFancyString(s);
        Assert.Equal(expected, actual);
    }
}
