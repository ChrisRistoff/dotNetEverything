using LeetCode.Easy;

public class ThreeDivisorsTests
{
    private readonly ThreeDivisorsSolution _solution = new();

    [Fact]
    public void ThreeDivisorsTest1()
    {
        var n = 2;
        var expected = false;
        var actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest2()
    {
        var n = 4;
        var expected = true;
        var actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest3()
    {
        var n = 1;
        var expected = false;
        var actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest4()
    {
        var n = 10000;
        var expected = false;
        var actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest5()
    {
        var n = 9;
        var expected = true;
        var actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }
}
