namespace Tests.leetCodeTests.Easy;

public class NumOfSubstringsTests
{
    private readonly NumOfSubstringsSolution _solution = new();

    [Fact]
    public void NumOfSubstringsTest1()
    {
        string[] patterns = ["a", "abc", "bc", "d"];
        string word = "abc";
        int expected = 3;
        int actual = _solution.NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest2()
    {
        string[] patterns = ["a", "b", "c"];
        string word = "aaaaabbbbb";
        int expected = 2;
        int actual = _solution.NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest3()
    {
        string[] patterns = ["a", "a", "a"];
        string word = "ab";
        int expected = 3;
        int actual = _solution.NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest4()
    {
        string[] patterns = ["a", "a", "a"];
        string word = "a";
        int expected = 3;
        int actual = _solution.NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumOfSubstringsTest5()
    {
        string[] patterns = ["a", "a", "a"];
        string word = "b";
        int expected = 0;
        int actual = _solution.NumOfStrings(patterns, word);
        Assert.Equal(expected, actual);
    }
}
