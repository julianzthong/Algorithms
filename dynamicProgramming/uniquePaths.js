/*
A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?
Example 1:
Input: m = 3, n = 7
Output: 28

Example 2:
Input: m = 3, n = 2
Output: 3
Explanation:
From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down

Example 3:
Input: m = 7, n = 3
Output: 28

Example 4:
Input: m = 3, n = 3
Output: 6
Constraints:

1 <= m, n <= 100
It's guaranteed that the answer will be less than or equal to 2 * 109.
*/
/**
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
var uniquePathsMemo = function(m, n, memo = {}) {
  const key = m + ',' + n;
  const reverseKey = n + ',' + m;
  if (key in memo || reverseKey in memo) {
    return memo[key]
  }
  if (m === 1 && n === 1) {
    return 1;
  }
  if (n === 0 || m === 0) {
    return 0;
  }
  memo[key] = uniquePathsMemo(m-1, n, memo) + uniquePathsMemo(m, n-1, memo);
  memo[reverseKey] = memo[key];
  return memo[key]
};

var uniquePathsTab = function(m, n) {
  const table = Array(m + 1)
  .fill()
  .map(() => Array(n + 1).fill(0));
  table[1][1] = 1;

  for (let i = 0; i <= n; i++) {
    for (let j = 0; j <= m; j++) {
      let current = table[i][j];
      if (i + 1 <= n) table[i+1][j] += current;
      if (j + 1 <= m) table[i][j+1] += current;
    }
  }
  return table[m][n];
}

console.log(uniquePathsTab(3,2)) // 3
console.log(uniquePathsTab(5,5)) // 70
console.log(uniquePathsTab(4,4)) // 20
console.log(uniquePathsTab(10,10)) // 48620
console.log(uniquePathsTab(18,18)) // 2333606220
