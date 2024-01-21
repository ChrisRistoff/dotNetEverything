using LeetCode.Easy;

public class MaxDiffBetweenElementsTests
{
    [Fact]
    public void MaxDiffBetweenElementsTest1()
    {
        var nums = new int[] { 7, 1, 5, 4 };
        var expected = 4;
        var actual = new MaxDiffBetweenElementsSolution().MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest2()
    {
        var nums = new int[] { 9, 4, 3, 2 };
        var expected = -1;
        var actual = new MaxDiffBetweenElementsSolution().MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest3()
    {
        var nums = new int[] { 1, 5, 2, 10 };
        var expected = 9;
        var actual = new MaxDiffBetweenElementsSolution().MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest4()
    {
        var nums = new int[] { 1, 2, 3, 4, 5 };
        var expected = 4;
        var actual = new MaxDiffBetweenElementsSolution().MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest5()
    {
        var nums = new int[] { 5, 4, 3, 2, 1 };
        var expected = -1;
        var actual = new MaxDiffBetweenElementsSolution().MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }
}
