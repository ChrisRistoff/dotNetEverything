using LeetCode.Easy;

namespace Tests.leetCodeTests.Easy;

public class LargestOddNumberTests
{
    private readonly LargestOddNumberInString _solution = new();

    [Fact]
    public void LargestOddNumberTest1()
    {
        string num = "52";
        string expected = "5";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest2()
    {
        string num = "4206";
        string expected = "";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest3()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest4()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest5()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest6()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest7()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest8()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargestOddNumberTest9()
    {
        string num = "35427";
        string expected = "35427";
        string actual = _solution.LargestOddNumber(num);
        Assert.Equal(expected, actual);
    }
}
