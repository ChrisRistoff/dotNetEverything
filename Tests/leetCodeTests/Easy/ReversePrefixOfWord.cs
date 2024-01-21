using LeetCode.Easy;

public class ReversePrefixOfWordTests
{
    private readonly ReversePrefixOfWordSolution _solution = new();

    [Fact]
    public void Test1()
    {
        string word = "abcdefd";
        char ch = 'd';
        string expected = "dcbaefd";
        string actual = _solution.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        string word = "xyxzxe";
        char ch = 'z';
        string expected = "zxyxxe";
        string actual = _solution.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        string word = "abcd";
        char ch = 'z';
        string expected = "abcd";
        string actual = _solution.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        string word = "abcdefd";
        char ch = 'e';
        string expected = "edcbafd";
        string actual = _solution.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }

}
