/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.


Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false
*/

namespace LeetCode.Easy;

public class ValidParenthesesSolution {
    public bool IsValid(string s) {
        Dictionary<char, char> parMap = new();
        parMap.Add(')', '(');
        parMap.Add('}', '{');
        parMap.Add(']', '[');

        Stack<char> parStack = new();

        for (int i = 0; i < s.Length; i++)
        {
            if(parMap.ContainsValue(s[i]))
            {
                parStack.Push(s[i]);
            }
            else if(parStack.Count == 0 || parStack.Pop() != parMap[s[i]])
            {
                return false;
            }
        }

        return parStack.Count == 0;
    }
}
