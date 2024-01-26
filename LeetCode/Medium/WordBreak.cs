/*
Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

Note that the same word in the dictionary may be reused multiple times in the segmentation.


Example 1:
Input: s = "leetcode", wordDict = ["leet","code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".

Example 2:
Input: s = "applepenapple", wordDict = ["apple","pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
Note that you are allowed to reuse a dictionary word.

Example 3:
Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
Output: false
*/

using System.Text;

namespace LeetCode.Medium;

public class WordBreakSolution {

    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> words = new(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;

        for (int i = 0; i <= s.Length; i++)
        {
            StringBuilder currWord = new();
            for (int j = i-1; j >= 0; j--)
            {
                currWord.Insert(0, s[j]);
                if (dp[j] && words.Contains(currWord.ToString()))
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[s.Length];
    }


    public bool WordBreakFail(string s, IList<string> wordDict) {
        HashSet<string> words = new(wordDict);
        List<string> foundWords = new();

        for(int i = 0; i < s.Length; i++)
        {
            int currLen = foundWords.Count;
            StringBuilder currWord = new();
            for (int j = i; j < s.Length; j++)
            {
                currWord.Append(s[j]);

                if (words.Contains(currWord.ToString()))
                {
                    i = j;
                    foundWords.Add(currWord.ToString());
                    break;
                }
            }
        }

        for (int i = 0; i < foundWords.Count; i++)
        {
            if (!wordDict.Contains(foundWords[i]))
            {
                return false;
            }
        }

        return true;
    }
}
