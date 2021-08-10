/*Given a string s, return the longest palindromic substring in s.

Example 1:
Input: s = "babad"
Output: "bab"
Note: "aba" is also a valid answer.

Example 2:
Input: s = "cbbd"
Output: "bb"

Example 3:
Input: s = "a"
Output: "a"

Example 4:
Input: s = "ac"
Output: "a"

Constraints:
1 <= s.length <= 1000
s consist of only digits and English letters.*/

/**
 * @param {string} s
 * @return {string}
 */
 var longestPalindrome = function(s) {
   let n = s.length;
  const table = Array(n + 1)
  .fill()
  .map(()=>Array(n + 1).fill(false));

  let lps = ''

  // fill single letters
  for (let i = 0; i < n; i++) {
    table[i][i] = true;
    lps = s.substring(i,i+1)
  }

  // double letters
  for (let i = 0; i < n; i++) {
    if (i + 1 < n && s[i] === s[i+1]) {
      table[i][i+1] = true;
      lps = s.substring(i, i+2);
    }
  }

  for (let )
  console.log(table)
  console.log(lps);
};

longestPalindrome('babad');