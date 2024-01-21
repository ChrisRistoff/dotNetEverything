using LeetCode.Easy;

public class MakeFancyStringTests()
{
    [Fact]
    public void MakeFancyStringTest1()
    {
        var s = "leeetcode";
        var expected = "leetcode";
        var actual = new MakeFancyStringSolution().MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest2()
    {
        var s = "aaabaaaa";
        var expected = "aabaa";
        var actual = new MakeFancyStringSolution().MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest3()
    {
        var s = "aab";
        var expected = "aab";
        var actual = new MakeFancyStringSolution().MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest4()
    {
        var s = "a";
        var expected = "a";
        var actual = new MakeFancyStringSolution().MakeFancyString(s);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MakeFancyStringTest5()
    {
        var s = "aa";
        var expected = "aa";
        var actual = new MakeFancyStringSolution().MakeFancyString(s);
        Assert.Equal(expected, actual);
    }
}
