using LeetCode.Easy;

namespace Tests.leetCodeTests.Easy;

public class CheckAllNumsInRangeTests
{
    private readonly CheckRange _solution = new();

    [Fact]
    public void CheckAllNumsInRangeTest1()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, 2, 5);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest2()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 10 }, new int[] { 10, 20 } }, 21, 21);
        Assert.False(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest3()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 50);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest4()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 49);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest5()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 2, 49);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest6()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 2, 50);
        Assert.True(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest7()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 1, 51);
        Assert.False(result);
    }

    [Fact]
    public void CheckAllNumsInRangeTest8()
    {
        bool result = _solution.IsCovered(new int[][] { new int[] { 1, 50 } }, 0, 50);
        Assert.False(result);
    }
}
