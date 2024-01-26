namespace LeetCode.Easy;

public class MergeSortedArrayTests()
{
    private readonly MergeSortedArraysSolution _solution = new();

    [Fact]
    public void MergeSortedArrayTest1()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int[] nums2 = [2, 5, 6];
        int m = 3;
        int n = 3;

        _solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Fact]
    public void MergeSortedArrayTest2()
    {
        int[] nums1 = [1];
        int[] nums2 = [];
        int m = 1;
        int n = 0;

        _solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new int[] { 1 }, nums1);
    }

    [Fact]
    public void MergeSortedArrayTest3()
    {
        int[] nums1 = [0];
        int[] nums2 = [1];
        int m = 0;
        int n = 1;
        _solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new int[] { 1 }, nums1);
    }

    [Fact]
    public void MergeSortedArrayTest4()
    {
        int[] nums1 = [0, 0, 0, 0, 0];
        int[] nums2 = [1, 2, 3, 4, 5];

        int m = 0;
        int n = 5;

        _solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, nums1);
    }
}
