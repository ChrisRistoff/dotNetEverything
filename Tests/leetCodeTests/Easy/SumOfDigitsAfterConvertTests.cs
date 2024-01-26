using LeetCode.Easy;

public class SumOfDigitsAfterConvertTests
{
    private readonly SumOfDigitsAfterConvertSolution _solution = new();

    [Fact]
    public void SumOfDigitsAfterConvertTest1()
    {
        string s = "iiii";
        int k = 1;
        int expected = 36;
        int actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest2()
    {
        string s = "leetcode";
        int k = 2;
        int expected = 6;
        int actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest3()
    {
        string s = "zbax";
        int k = 2;
        int expected = 8;
        int actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest4()
    {
        string s = "a";
        int k = 1;
        int expected = 1;
        int actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }
}
