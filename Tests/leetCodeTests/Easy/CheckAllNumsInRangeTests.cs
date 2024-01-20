using LeetCode.Easy;

public class CheckAllNumsInRangeTests
{
    [Fact]
    public void CheckAllNumsInRangeTest1()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, 2, 5);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest2()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 10 }, new int[] { 10, 20 } }, 21, 21);
        Assert.False(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest3()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 50);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest4()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 49);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest5()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 2, 49);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest6()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 2, 50);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest7()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 51);
        Assert.False(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest8()
    {
        var solution = new CheckRange();
        var result = solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 0, 50);
        Assert.False(result);
    }
}
