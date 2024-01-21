using LeetCode.Easy;

public class NumOfSubstringsTests
{
    [Fact]
    public void NumOfSubstringsTest1()
    {
        var patterns = new string[] { "a", "abc", "bc", "d" };
        var word = "abc";
        var expected = 3;
        var actual = new NumOfSubstringsSolution().NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest2()
    {
        var patterns = new string[] { "a", "b", "c" };
        var word = "aaaaabbbbb";
        var expected = 2;
        var actual = new NumOfSubstringsSolution().NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest3()
    {
        var patterns = new string[] { "a", "a", "a" };
        var word = "ab";
        var expected = 3;
        var actual = new NumOfSubstringsSolution().NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest4()
    {
        var patterns = new string[] { "a", "a", "a" };
        var word = "a";
        var expected = 3;
        var actual = new NumOfSubstringsSolution().NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest5()
    {
        var patterns = new string[] { "a", "a", "a" };
        var word = "b";
        var expected = 0;
        var actual = new NumOfSubstringsSolution().NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }
}
