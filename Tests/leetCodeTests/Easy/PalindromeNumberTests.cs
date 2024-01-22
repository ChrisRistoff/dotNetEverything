using LeetCode.Easy;

public class PalindromeNumberTests
{
    private readonly PalindromeNumberSolution _solution = new();

    [Fact]
    public void PalindromeNumberTest1()
    {
        var input = 121;
        var expected = true;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest2()
    {
        var input = -121;
        var expected = false;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest3()
    {
        var input = 10;
        var expected = false;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest4()
    {
        var input = -101;
        var expected = false;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest5()
    {
        var input = 0;
        var expected = true;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest6()
    {
        var input = 1000021;
        var expected = false;
        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}
