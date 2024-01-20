namespace LeetCode.Easy;

public class MergeSortedArrayTests()
{
   [Fact]
   public void MergeSortedArrayTest1()
   {
       var solution = new MergeSortedArraysSolution();
       int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
       int[] nums2 = new int[] { 2, 5, 6 };
       int m = 3;
       int n = 3;

       solution.Merge(nums1, m, nums2, n);

       Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
   }

   [Fact]
   public void MergeSortedArrayTest2()
   {
       var solution = new MergeSortedArraysSolution();

         int[] nums1 = new int[] { 1 };
         int[] nums2 = new int[] { };
         int m = 1;
         int n = 0;

         solution.Merge(nums1, m, nums2, n);

         Assert.Equal(new int[] { 1 }, nums1);
   }

   [Fact]
   public void MergeSortedArrayTest3()
   {
       var solution = new MergeSortedArraysSolution();

       int[] nums1 = new int[] { 0 };
       int[] nums2 = new int[] { 1 };
       int m = 0;
       int n = 1;

       solution.Merge(nums1, m, nums2, n);

       Assert.Equal(new int[] { 1 }, nums1);
   }

   [Fact]
   public void MergeSortedArrayTest4()
   {
       var solution = new MergeSortedArraysSolution();

       int[] nums1 = new int[] { 0, 0, 0, 0, 0 };
       int[] nums2 = new int[] { 1, 2, 3, 4, 5 };

       int m = 0;
       int n = 5;

       solution.Merge(nums1, m, nums2, n);

       Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, nums1);
   }
}
