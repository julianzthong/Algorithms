namespace Runner.Algorithms;

public partial class Solution
{
  public int LengthOfLongestSubstring(string s)
  {
    HashSet<char> seen = new();
    int left = 0;
    int maxLength = 0;

    for (var right = 0; right < s.Length; right++)
    {
      while (seen.Contains(s[right]))
      {
        seen.Remove(s[left]);
        left++;
      }

      seen.Add(s[right]);
      maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
  }
}

/*
3. Longest Substring Without Repeating Characters
Medium
Topics
premium lock iconCompanies
Hint

Given a string s, find the length of the longest

without duplicate characters.



Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.



Constraints:

    0 <= s.length <= 5 * 104
    s consists of English letters, digits, symbols and spaces.
*/