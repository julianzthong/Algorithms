public class Solution
{
  public int LengthOfLongestSubstring(string s)
  {
    int result = 0;
    int subStringLength = 1;
    List<string> splitString = s.Split("");
    int end = splitString.Count - 1;

    for (var i = 0; i < end; i++)
    {
      if (splitString[i] != splitString[i + 1])
      {
        subStringLength++;
      }
      else
      {
        if (subStringLength > result)
        {
          result = subStringLength;
        }
        subStringLength = 1;
      }
    }

    return result;
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