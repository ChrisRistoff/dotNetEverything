namespace Tests.leetCodeTests.Easy;

public class ContatenationOfArrayTests
{
    private readonly ContatenationOfArraySolution _solution = new();

    [Fact]
    public void ConcatArrayTest1()
    {
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest2()
    {
        int[] nums = [1, 3, 2, 1];
        int[] expected = [1, 3, 2, 1, 1, 3, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest3()
    {
        int[] nums = [1, 3, 2, 1, 1, 3, 2, 1];
        int[] expected = [1, 3, 2, 1, 1, 3, 2, 1, 1, 3, 2, 1, 1, 3, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest4()
    {
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest5()
    {
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest6()
    {
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];
        int[] actual = _solution.GetConcat(nums);
        Assert.Equal(expected, actual);
    }

}
