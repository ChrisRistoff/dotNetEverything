using LeetCode.Easy;

public class SumOfDigitsAfterConvertTests
{
    private readonly SumOfDigitsAfterConvertSolution _solution = new();

    [Fact]
    public void SumOfDigitsAfterConvertTest1()
    {
        var s = "iiii";
        var k = 1;
        var expected = 36;
        var actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest2()
    {
        var s = "leetcode";
        var k = 2;
        var expected = 6;
        var actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest3()
    {
        var s = "zbax";
        var k = 2;
        var expected = 8;
        var actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfDigitsAfterConvertTest4()
    {
        var s = "a";
        var k = 1;
        var expected = 1;
        var actual = _solution.GetLucky(s, k);
        Assert.Equal(expected, actual);
    }
}
