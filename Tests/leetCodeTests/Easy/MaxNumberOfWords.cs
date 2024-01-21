using LeetCode.Easy;

public class MaxNumberOfWrodsTests
{
    [Fact]
    public void MaxNumberOfWordsTest1()
    {
        var text = "hello world";
        var brokenLetters = "ad";
        var expected = 1;
        var actual = new MaxNumberOfWordsSolution().CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest2()
    {
        var text = "leet code";
        var brokenLetters = "lt";
        var expected = 1;
        var actual = new MaxNumberOfWordsSolution().CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest3()
    {
        var text = "leet code";
        var brokenLetters = "e";
        var expected = 0;
        var actual = new MaxNumberOfWordsSolution().CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest4()
    {
        var text = "hello world";
        var brokenLetters = "ad";
        var expected = 1;
        var actual = new MaxNumberOfWordsSolution().CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxNumberOfWordsTest5()
    {
        var text = "leet code";
        var brokenLetters = "lt";
        var expected = 1;
        var actual = new MaxNumberOfWordsSolution().CanBeTypedWords(text, brokenLetters);
        Assert.Equal(expected, actual);
    }
}
