namespace Tests.leetCodeTests.Easy;

public class MaxProductDifferenceTests
{
    private readonly MaximumProductDifferenceSolution _solution = new();

    [Fact]
    public void MaxProductDifferenceTest1()
    {
        int[] nums = [5, 6, 2, 7, 4];
        int expected = 34;
        int actual = _solution.MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest2()
    {
        int[] nums = [4, 2, 5, 9, 7, 4, 8];
        int expected = 64;
        int actual = _solution.MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest3()
    {
        int[] nums = [1, 5, 4, 5];
        int expected = 21;
        int actual = _solution.MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest4()
    {
        int[] nums = [4, 4];
        int expected = 0;
        int actual = _solution.MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }
}
