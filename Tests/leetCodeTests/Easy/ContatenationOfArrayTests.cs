using LeetCode.Easy;

public class ContatenationOfArrayTests
{
    [Fact]
    public void ConcatArrayTest1()
    {
        var nums = new int[] { 1, 2, 1 };
        var expected = new int[] { 1, 2, 1, 1, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest2()
    {
        var nums = new int[] { 1, 3, 2, 1 };
        var expected = new int[] { 1, 3, 2, 1, 1, 3, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest3()
    {
        var nums = new int[] { 1, 3, 2, 1, 1, 3, 2, 1 };
        var expected = new int[] { 1, 3, 2, 1, 1, 3, 2, 1, 1, 3, 2, 1, 1, 3, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest4()
    {
        var nums = new int[] { 1, 2, 1 };
        var expected = new int[] { 1, 2, 1, 1, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest5()
    {
        var nums = new int[] { 1, 2, 1 };
        var expected = new int[] { 1, 2, 1, 1, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConcatArrayTest6()
    {
        var nums = new int[] { 1, 2, 1 };
        var expected = new int[] { 1, 2, 1, 1, 2, 1 };
        var actual = new ContatenationOfArraySolution().GetConcat(nums);
        Assert.Equal(expected, actual);
    }

}
