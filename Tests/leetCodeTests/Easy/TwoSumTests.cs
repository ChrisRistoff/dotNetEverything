using LeetCode.Easy;

public class TwoSumTests()
{
    [Fact]
    public void TwoSumTest1()
    {
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new int[] { 0, 1 };
        var actual = new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoSumTest2()
    {
        var nums = new int[] { 3, 2, 4 };
        var target = 6;
        var expected = new int[] { 1, 2 };
        var actual = new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoSumTest3()
    {
        var nums = new int[] { 3, 3 };
        var target = 6;
        var expected = new int[] { 0, 1 };
        var actual =  new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
