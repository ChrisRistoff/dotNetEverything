using LeetCode.Easy;

public class MinDiffHighestLowestTests
{
    [Fact]
    public void MinDiffHighestLowestTest1()
    {
        var nums = new int[] { 90 };
        var k = 1;
        var expected = 0;
        var actual = new MinDiffHighestLowestSolution().MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest2()
    {
        var nums = new int[] { 9, 4, 1, 7 };
        var k = 2;
        var expected = 2;
        var actual = new MinDiffHighestLowestSolution().MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest3()
    {
        var nums = new int[] { 9, 4, 1, 7 };
        var k = 3;
        var expected = 5;
        var actual = new MinDiffHighestLowestSolution().MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MinDiffHighestLowestTest4()
    {
        var nums = new int[] { 9, 4, 1, 7 };
        var k = 4;
        var expected = 8;
        var actual = new MinDiffHighestLowestSolution().MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
