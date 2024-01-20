using LeetCode.Easy;

public class CheckAllCharactersOccurencesTests
{
    [Fact]
    public void CheckAllCharactersOccurencesTest1()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("abacbc");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest2()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aaabb");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest3()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("a");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest4()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aab");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest5()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aabb");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest6()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aabbcc");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest7()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aabbccc");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest8()
    {
        var solution = new CheckOccurrences();
        var result = solution.AreOccurrencesEqual("aabbccccd");
        Assert.False(result);
    }
}
