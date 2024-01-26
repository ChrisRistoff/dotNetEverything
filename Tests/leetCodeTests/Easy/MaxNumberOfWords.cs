namespace Tests.leetCodeTests.Easy;

public class MaxNumberOfWrodsTests
{
    private readonly MaxNumberOfWordsSolution _solution = new();

    [Fact]
    public void MaxNumberOfWordsTest1()
    {
        string text = "hello world";
        string brokenLetters = "ad";
        int expected = 1;
        int actual = _solution.CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest2()
    {
        string text = "leet code";
        string brokenLetters = "lt";
        int expected = 1;
        int actual = _solution.CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest3()
    {
        string text = "leet code";
        string brokenLetters = "e";
        int expected = 0;
        int actual = _solution.CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest4()
    {
        string text = "hello world";
        string brokenLetters = "ad";
        int expected = 1;
        int actual = _solution.CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest5()
    {
        string text = "leet code";
        string brokenLetters = "lt";
        int expected = 1;
        int actual = _solution.CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }
}
