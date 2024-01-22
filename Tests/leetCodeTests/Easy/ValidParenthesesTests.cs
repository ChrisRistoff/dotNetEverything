using LeetCode.Easy;

public class ValidParenthesesTests
{
    private readonly ValidParenthesesSolution _solution = new();

    [Fact]
    public void ValidParenthesesTest1()
    {
        var input = "()";
        var expected = true;
        var actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest2()
    {
        var input = "()[]{}";
        var expected = true;
        var actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest3()
    {
        var input = "(]";
        var expected = false;
        var actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest4()
    {
        var input = "([)]";
        var expected = false;
        var actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest5()
    {
        var input = "{[]}";
        var expected = true;
        var actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }
}
