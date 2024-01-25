/*
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
or -1 if needle is not part of haystack.


Example 1:
Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.

Example 2:
Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/

using System.Text;

namespace LeetCode.Easy;

public class FindFirstOccurenceInStringSolution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == haystack.Length)
        {
            return needle == haystack ? 0 : -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            StringBuilder prefix = new();
            int j = i;

            while (j < haystack.Length)
            {
                prefix.Append(haystack[j]);

                if (prefix.ToString() == needle)
                {
                    return i;
                }
                else if (!needle.StartsWith(prefix.ToString()))
                {
                    break;
                }

                j++;
            }
        }

        return -1;
    }
}
