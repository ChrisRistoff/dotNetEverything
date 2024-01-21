using LeetCode.Easy;

public class ValidPalindromeTests
{
    private readonly ValidPalindromeSolution _solution = new();

    [Fact]
    public void ValidPaliTest1()
    {
        string input = "A man, a plan, a canal: Panama";
        bool expected = true;

        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidPaliTest2()
    {
        string input = "race a car";
        bool expected = false;

        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidPaliTest3()
    {
        string input = " ";
        bool expected = true;

        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidPaliTest4()
    {
        string input = "0P";
        bool expected = false;

        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}
