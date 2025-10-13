/*
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:
Input: rowIndex = 3
Output: [1,3,3,1]

Example 2:
Input: rowIndex = 0
Output: [1]

Example 3:
Input: rowIndex = 1
Output: [1,1]

Constraints:
0 <= rowIndex <= 33

Follow up: Could you optimize your algorithm to use only O(rowIndex) extra space?
*/
/**
 * @param {number} rowIndex
 * @return {number[]}
 */
var getRow = function(rowIndex) {
  let numberOfRows = rowIndex + 1
  const table = Array(numberOfRows).fill().map(()=>Array(0));
  for (let row = 0; row < numberOfRows; row++) {
    for (let num = 0; num <= row; num++) {
      if (num === 0 || num === row) {
        table[row][num] = 1;
      }
      if (num > 0 && num < row) {
        table[row][num] = table[row - 1][num - 1] + table[row - 1][num];
      }
    }
  }
  return table[rowIndex]
};

console.log(getRow(5))