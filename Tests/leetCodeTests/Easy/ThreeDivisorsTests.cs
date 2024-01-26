using LeetCode.Easy;

public class ThreeDivisorsTests
{
    private readonly ThreeDivisorsSolution _solution = new();

    [Fact]
    public void ThreeDivisorsTest1()
    {
        int n = 2;
        bool expected = false;
        bool actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest2()
    {
        int n = 4;
        bool expected = true;
        bool actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest3()
    {
        int n = 1;
        bool expected = false;
        bool actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest4()
    {
        int n = 10000;
        bool expected = false;
        bool actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeDivisorsTest5()
    {
        int n = 9;
        bool expected = true;
        bool actual = _solution.IsThree(n);
        Assert.Equal(expected, actual);
    }
}
