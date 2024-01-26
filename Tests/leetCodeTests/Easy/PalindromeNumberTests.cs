using LeetCode.Easy;

public class PalindromeNumberTests
{
    private readonly PalindromeNumberSolution _solution = new();

    [Fact]
    public void PalindromeNumberTest1()
    {
        int input = 121;
        bool expected = true;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest2()
    {
        int input = -121;
        bool expected = false;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest3()
    {
        int input = 10;
        bool expected = false;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest4()
    {
        int input = -101;
        bool expected = false;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest5()
    {
        int input = 0;
        bool expected = true;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PalindromeNumberTest6()
    {
        int input = 1000021;
        bool expected = false;
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}
