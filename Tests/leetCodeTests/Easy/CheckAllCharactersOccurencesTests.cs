using LeetCode.Easy;

public class CheckAllCharactersOccurencesTests
{
    private readonly CheckOccurrences _solution = new();

    [Fact]
    public void CheckAllCharactersOccurencesTest1()
    {
        var result = _solution.AreOccurrencesEqual("abacbc");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest2()
    {
        bool result = _solution.AreOccurrencesEqual("aaabb");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest3()
    {
        bool result = _solution.AreOccurrencesEqual("a");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest4()
    {
        bool result = _solution.AreOccurrencesEqual("aab");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest5()
    {
        bool result = _solution.AreOccurrencesEqual("aabb");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest6()
    {
        bool result = _solution.AreOccurrencesEqual("aabbcc");
        Assert.True(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest7()
    {
        bool result = _solution.AreOccurrencesEqual("aabbccc");
        Assert.False(result);
    }

    [Fact]
    public void CheckAllCharactersOccurencesTest8()
    {
        bool result = _solution.AreOccurrencesEqual("aabbccccd");
        Assert.False(result);
    }
}
