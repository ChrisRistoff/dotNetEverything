namespace Tests.leetCodeTests.Easy;

public class MaxDiffBetweenElementsTests
{
    private readonly MaxDiffBetweenElementsSolution _solution = new();

    [Fact]
    public void MaxDiffBetweenElementsTest1()
    {
        int[] nums = [7, 1, 5, 4];
        int expected = 4;
        int actual = _solution.MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest2()
    {
        int[] nums = [9, 4, 3, 2];
        int expected = -1;
        int actual = _solution.MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest3()
    {
        int[] nums = [1, 5, 2, 10];
        int expected = 9;
        int actual = _solution.MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest4()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int expected = 4;
        int actual = _solution.MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MaxDiffBetweenElementsTest5()
    {
        int[] nums = [5, 4, 3, 2, 1];
        int expected = -1;
        int actual = _solution.MaximumDifference(nums);
        Assert.Equal(expected, actual);
    }
}
