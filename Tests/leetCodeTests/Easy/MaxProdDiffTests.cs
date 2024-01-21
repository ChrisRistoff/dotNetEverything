using LeetCode.Easy;

public class MaxProductDifferenceTests
{
    [Fact]
    public void MaxProductDifferenceTest1()
    {
        var nums = new int[] { 5, 6, 2, 7, 4 };
        var expected = 34;
        var actual = new MaximumProductDifferenceSolution().MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest2()
    {
        var nums = new int[] { 4, 2, 5, 9, 7, 4, 8 };
        var expected = 64;
        var actual = new MaximumProductDifferenceSolution().MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest3()
    {
        var nums = new int[] { 1, 5, 4, 5 };
        var expected = 21;
        var actual = new MaximumProductDifferenceSolution().MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxProductDifferenceTest4()
    {
        var nums = new int[] { 4, 4 };
        var expected = 0;
        var actual = new MaximumProductDifferenceSolution().MaxProductDifference(nums);
        Assert.Equal(expected, actual);
    }
}
