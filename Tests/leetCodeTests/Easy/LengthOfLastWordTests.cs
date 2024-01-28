using LeetCode.Easy;

public class LengthOfLastWordTests
{
    private readonly LengthOfLastWordSolution _solution = new();

    [Fact]
    public void Example1()
    {
        var input = "Hello World";
        var expected = 5;
        var actual = _solution.LengthOfLastWord(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        var input = "   fly me   to   the moon  ";
        var expected = 4;
        var actual = _solution.LengthOfLastWord(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        var input = "luffy is still joyboy";
        var expected = 6;
        var actual = _solution.LengthOfLastWord(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example4()
    {
        var input = "a";
        var expected = 1;
        var actual = _solution.LengthOfLastWord(input);
        Assert.Equal(expected, actual);
    }
}
