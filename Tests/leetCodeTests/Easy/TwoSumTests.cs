using LeetCode.Easy;

public class TwoSumTests()
{
    [Fact]
    public void TwoSumTest1()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] expected = new int[] { 0, 1 };
        int[] actual = new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoSumTest2()
    {
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;
        int[] expected = new int[] { 1, 2 };
        int[] actual = new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoSumTest3()
    {
        int[] nums = new int[] { 3, 3 };
        int target = 6;
        int[] expected = new int[] { 0, 1 };
        int[] actual =  new TwoSumSolution().TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
