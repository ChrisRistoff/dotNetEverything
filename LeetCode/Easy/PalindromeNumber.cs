/*
Given an integer x, return true if x is a
palindrome, and false otherwise.


Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
*/

using System.Text;

namespace LeetCode.Easy;

public class PalindromeNumberSolution {
    public bool IsPalindrome(int x) {
        string strNum = x.ToString();

        return strNum == Reverse(strNum);
    }

    public string Reverse(string x)
    {
        StringBuilder newNum = new();

        for (int i = x.Length - 1; i >= 0; i--)
        {
            newNum.Append(x[i]);
        }

        return newNum.ToString();
    }
}
