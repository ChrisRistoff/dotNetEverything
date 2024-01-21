using LeetCode.Easy;

public class StrictlyIncreasingTests
{
    private readonly StrictlyIncreasingSolution _solution = new();

    [Fact]
    public void Test1()
    {
        int[] nums = { 1, 2, 10, 5, 7 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = { 2, 3, 1, 2 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.False(result);
    }

    [Fact]
    public void Test3()
    {
        int[] nums = { 1, 1, 1 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.False(result);
    }

    [Fact]
    public void Test4()
    {
        int[] nums = { 105, 924, 32, 968 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test5()
    {
        int[] nums = { 1, 2, 3 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test6()
    {
        int[] nums = { 1, 1 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test7()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test8()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test9()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 9 };
        bool result = _solution.CanBeIncreasing(nums);
        Assert.True(result);
    }
}
