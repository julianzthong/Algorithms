/*
Given an integer numRows, return the first numRows of Pascal's triangle.

Example 1:
Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Example 2:
Input: numRows = 1
Output: [[1]]

Constraints:
1 <= numRows <= 30
*/
/**
 * @param {number} numRows
 * @return {number[][]}
 */
 var generate = function(numRows) {
  const table = Array(numRows)
  .fill()
  .map(() => Array())

  for (let row = 0; row < numRows; row++) {
    for (let num = 0; num <= row; num++) {
      if (num === 0 || num === row) {
        table[row][num] = 1;
      }
      if (num > 0 && num < row) {
        table[row][num] = table[row - 1][num - 1] + table[row - 1][num];
      }
    }
  }
  console.log(table)

};

generate(5);