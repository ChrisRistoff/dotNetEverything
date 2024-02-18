using LeetCode.Easy;

public class SingleNumberTests
{
    private readonly SingleNumberSolution _solution = new();

    [Fact]
    public void Example1()
    {
        int[] nums = { 2, 2, 1 };
        int expected = 1;
        int actual = _solution.SingleNumber(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = { 4, 1, 2, 1, 2 };
        int expected = 4;
        int actual = _solution.SingleNumber(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        int[] nums = { 1 };
        int expected = 1;
        int actual = _solution.SingleNumber(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example4()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int expected = 1;
        int actual = _solution.SingleNumber(nums);
        Assert.Equal(expected, actual);
    }
}
