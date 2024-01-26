namespace Tests.leetCodeTests.Easy;

public class MinDiffHighestLowestTests
{
    private readonly MinDiffHighestLowestSolution _solution = new();

    [Fact]
    public void MinDiffHighestLowestTest1()
    {
        int[] nums = [90];
        int k = 1;
        int expected = 0;
        int actual = _solution.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest2()
    {
        int[] nums = [9, 4, 1, 7];
        int k = 2;
        int expected = 2;
        int actual = _solution.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest3()
    {
        int[] nums = [9, 4, 1, 7];
        int k = 3;
        int expected = 5;
        int actual = _solution.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest4()
    {
        int[] nums = [9, 4, 1, 7];
        int k = 4;
        int expected = 8;
        int actual = _solution.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
