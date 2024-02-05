/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters.
No two characters may map to the same character, but a character may map to itself.


Example 1:
Input: s = "egg", t = "add"
Output: true

Example 2:
Input: s = "foo", t = "bar"
Output: false

Example 3:
Input: s = "paper", t = "title"
Output: true
*/

public class IsomorphicStringsSolution {
    public bool IsIsomorphic(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> sMap = new();
        Dictionary<char, int> tMap = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (sMap.ContainsKey(s[i]) && tMap.ContainsKey(t[i]))
            {
                if (sMap[s[i]] != tMap[t[i]])
                {
                    return false;
                }
            }
            else if (sMap.ContainsKey(s[i]) || tMap.ContainsKey(t[i]))
            {
                return false;
            }
            else
            {
                sMap[s[i]] = i;
                tMap[t[i]] = i;
            }
        }

        return true;
    }
}
