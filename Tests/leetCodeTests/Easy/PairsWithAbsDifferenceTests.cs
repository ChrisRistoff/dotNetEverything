namespace Tests.leetCodeTests.Easy;

public class PairsWithAbsDifferenceTests
{
    private readonly PairsWithAbsDifferenceSolution _solution = new();

    [Fact]
    public void PairsWithAbsDifferenceTest1()
    {
        int[] nums = [1, 2, 2, 1];
        int k = 1;
        int expected = 4;
        int actual = _solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest2()
    {
        int[] nums = [1, 3];
        int k = 3;
        int expected = 0;
        int actual = _solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest3()
    {
        int[] nums = [3, 2, 1, 5, 4];
        int k = 2;
        int expected = 3;
        int actual = _solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest4()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int k = 1;
        int expected = 4;
        int actual = _solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
