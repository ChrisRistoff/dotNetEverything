/*
Given a string s, return true if s is a good string, or false otherwise.

    A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).



    Example 1:

Input: s = "abacbc"
Output: true
Explanation: The characters that appear in s are 'a', 'b', and 'c'. All characters occur 2 times in s.
    Example 2:

Input: s = "aaabb"
Output: false
Explanation: The characters that appear in s are 'a' and 'b'.
'a' occurs 3 times while 'b' occurs 2 times, which is not the same number of times.
*/

namespace LeetCode.Easy;

public class CheckOccurrences{
    public bool AreOccurrencesEqual(string s) {
        Dictionary<string, int> letterCounts = new Dictionary<string, int>();
        foreach (char letter in s)
        {
            string currLetter = letter.ToString();
            if (letterCounts.ContainsKey(currLetter))
            {
                letterCounts[currLetter]++;
            }
            else
            {
                letterCounts.Add(currLetter, 1);
            }
        }

        int firstCount = letterCounts.Values.First();
        foreach (var d in letterCounts)
        {
            if (d.Value != firstCount) return false;
        }

        return true;
    }
}
