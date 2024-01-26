using LeetCode.Easy;

public class ValidParenthesesTests
{
    private readonly ValidParenthesesSolution _solution = new();

    [Fact]
    public void ValidParenthesesTest1()
    {
        string input = "()";
        bool expected = true;
        bool actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest2()
    {
        string input = "()[]{}";
        bool expected = true;
        bool actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest3()
    {
        string input = "(]";
        bool expected = false;
        bool actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest4()
    {
        string input = "([)]";
        bool expected = false;
        bool actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidParenthesesTest5()
    {
        string input = "{[]}";
        bool expected = true;
        bool actual = _solution.IsValid(input);
        Assert.Equal(expected, actual);
    }
}
