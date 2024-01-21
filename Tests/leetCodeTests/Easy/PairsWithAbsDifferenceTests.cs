using LeetCode.Easy;

public class PairsWithAbsDifferenceTests
{
    [Fact]
    public void PairsWithAbsDifferenceTest1()
    {
        var nums = new int[] { 1, 2, 2, 1 };
        var k = 1;
        var expected = 4;
        var actual = new PairsWithAbsDifferenceSolution().CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest2()
    {
        var nums = new int[] { 1, 3 };
        var k = 3;
        var expected = 0;
        var actual = new PairsWithAbsDifferenceSolution().CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest3()
    {
        var nums = new int[] { 3, 2, 1, 5, 4 };
        var k = 2;
        var expected = 3;
        var actual = new PairsWithAbsDifferenceSolution().CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PairsWithAbsDifferenceTest4()
    {
        var nums = new int[] { 1, 2, 3, 4, 5 };
        var k = 1;
        var expected = 4;
        var actual = new PairsWithAbsDifferenceSolution().CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
