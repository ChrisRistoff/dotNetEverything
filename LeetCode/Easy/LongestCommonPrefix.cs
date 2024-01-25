/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".


Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/


using System.Text;

namespace LeetCode.Easy;

public class LongestCommonPrefixSolution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder prefix = new();
        for (int i = 0; i < strs[0].Length; i++)
        {
            prefix.Append(strs[0][i]);
            if(!IsPrefix(prefix.ToString(), strs))
            {
                prefix.Remove(prefix.Length-1, 1);
                return prefix.ToString();
            }
        }

        return prefix.ToString();
    }

    private bool IsPrefix(string prefix, string[] strs)
    {
        for(int i = 0; i < strs.Length; i++)
        {
            if(!strs[i].StartsWith(prefix))
            {
                return false;
            }
        }

        return true;
    }
}
