/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.


Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:
Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
*/

using System.Text;
namespace LeetCode.Easy;

public class ValidPalindromeSolution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }

        s = s.ToLower();
        StringBuilder newStringBuild = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                newStringBuild.Append(s[i]);
            }
        }

        string newString = newStringBuild.ToString();

        string reversed = Reverse(newString);

        return newString == reversed;
    }

    private string Reverse(string s)
    {
        StringBuilder reversed = new();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed.Append(s[i]);
        }

        return reversed.ToString();
    }
}
