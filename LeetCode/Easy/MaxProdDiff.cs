/*
The product difference between two pairs (a, b) and (c, d) is defined as (a * b) - (c * d).

    For example, the product difference between (5, 6) and (2, 7) is (5 * 6) - (2 * 7) = 16.
    Given an integer array nums, choose four distinct indices w, x, y, and z such that the product difference between pairs (nums[w], nums[x]) and (nums[y], nums[z]) is maximized.

    Return the maximum such product difference.



    Example 1:

Input: nums = [5,6,2,7,4]
Output: 34
Explanation: We can choose indices 1 and 3 for the first pair (6, 7) and indices 2 and 4 for the second pair (2, 4).
    The product difference is (6 * 7) - (2 * 4) = 34.
    Example 2:

Input: nums = [4,2,5,9,7,4,8]
Output: 64
Explanation: We can choose indices 3 and 6 for the first pair (9, 8) and indices 1 and 5 for the second pair (2, 4).
    The product difference is (9 * 8) - (2 * 4) = 64.
*/

public class MaximumProductDifference {
    public int MaxProductDifference(int[] nums)
    {

        int[] maxData = this.FindMax(nums);
        int max = maxData[0];

        int indexOfMax = maxData[1];

        int secondMax = this.FindSecondMax(nums, indexOfMax);

        int[] minData = this.FindMin(nums, max);
        int min = minData[0];
        int indexOfMin = minData[1];

        int secondMin = this.FindSecondMin(nums, max, indexOfMin);

        Console.WriteLine(max);
        Console.WriteLine(secondMax);
        Console.WriteLine(min);
        Console.WriteLine(secondMin);

        return (max * secondMax) - (min * secondMin);
    }


    private int[] FindMax(int[] nums)
    {
        int max = 0;
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                index = i;
            }
        }

        return new int[]{max, index};
    }
    private int FindSecondMax(int[] nums, int index)
    {
        int secondMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > secondMax && i != index) secondMax = nums[i];
        }

        return secondMax;
    }

    private int[] FindMin(int[] nums, int max)
    {
        int min = max;
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                index = i;
            }
        }

        return new int[] {min, index};
    }

    private int FindSecondMin(int[] nums, int max, int index)
    {
        int secondMin = max;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < secondMin && i != index) secondMin = nums[i];
        }

        return secondMin;
    }
}
