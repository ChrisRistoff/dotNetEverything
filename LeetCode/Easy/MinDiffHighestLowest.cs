/*
You are given a 0-indexed integer array nums, where nums[i] represents the score of the ith student. You are also given an integer k.

    Pick the scores of any k students from the array so that the difference between the highest and the lowest of the k scores is minimized.

    Return the minimum possible difference.



    Example 1:

Input: nums = [90], k = 1
Output: 0
Explanation: There is one way to pick score(s) of one student:
- [90]. The difference between the highest and lowest score is 90 - 90 = 0.
    The minimum possible difference is 0.
    Example 2:

Input: nums = [9,4,1,7], k = 2
Output: 2
Explanation: There are six ways to pick score(s) of two students:
- [9,4,1,7]. The difference between the highest and lowest score is 9 - 4 = 5.
- [9,4,1,7]. The difference between the highest and lowest score is 9 - 1 = 8.
- [9,4,1,7]. The difference between the highest and lowest score is 9 - 7 = 2.
- [9,4,1,7]. The difference between the highest and lowest score is 4 - 1 = 3.
- [9,4,1,7]. The difference between the highest and lowest score is 7 - 4 = 3.
- [9,4,1,7]. The difference between the highest and lowest score is 7 - 1 = 6.
    The minimum possible difference is 2.
*/

using System.Runtime.InteropServices.JavaScript;

public class MinDiffHighestLowest {
    public int MinimumDifference(int[] nums, int k)
    {
        List<int> indexes = new List<int>();
        List<int> maxNumbers = new List<int>();

        for (int i = 0; i < k; i++)
        {
            int[] data = FindNextHighest(nums, indexes);

            maxNumbers.Add(data[0]);
            indexes.Add(data[1]);
        }

        Console.WriteLine(string.Join(", ", maxNumbers));

        if (maxNumbers.Count == 1)
        {
            return 0;
        }

        int result = maxNumbers[0];
        for (int i = 1; i < maxNumbers.Count; i++)
        {
            result -= maxNumbers[i];
        }

        return result;
    }

    private int[] FindNextHighest(int[] numsArr, List<int> indexes)
    {
        int max = 0;
        int newIndex = numsArr.Length;
        for (int i = 0; i < numsArr.Length; i++)
        {
            if (numsArr[i] > max && !indexes.Contains(i))
            {
                max = numsArr[i];
                newIndex = i;
            }
        }

        return new int[]{max, newIndex};
    }
}
