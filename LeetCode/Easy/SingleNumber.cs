/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

Example 1:
Input: nums = [2,2,1]
Output: 1

Example 2:
Input: nums = [4,1,2,1,2]
Output: 4

Example 3:
Input: nums = [1]
Output: 1
*/

public class SingleNumberSolution {
    public int SingleNumber(int[] nums) {

        HashSet<int> set = new();

        foreach (int num in nums) {
            if (set.Contains(num)) {
                set.Remove(num);
            }
            else {
                set.Add(num);
            }
        }

        return set.First();
    }
}
