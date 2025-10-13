/*
You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once. Find this single element that appears only once.

Follow up: Your solution should run in O(log n) time and O(1) space.
Example 1:

Input: nums = [1,1,2,3,3,4,4,8,8]
Output: 2

Example 2:
Input: nums = [3,3,7,7,10,11,11]
Output: 10

Constraints:
1 <= nums.length <= 10^5
0 <= nums[i] <= 10^5
*/
/**
 * @param {number[]} nums
 * @return {number}
 */
/* Brute Force Method
var singleNonDuplicate = function(nums) {
  let n = nums.length;
  for (let i = 0; i < n; i+=2) {
    if (nums[i] === nums[i+1]) {
      continue;
    } else {
      return nums[i];
    }
  }
};
*/
// [3,3,7,7,10,11,11]
// [1,1,2,3,3,4,4,8,8]
//  0 1 2 3 4 5 6 7 8

var singleNonDuplicate = function(nums) {
  let left = 0;
  let right = nums.length - 1;
  let midpoint;

  while (left <= right) {
    midpoint = (left + (right - left) / 2);
    if (nums[midpoint] === nums[midpoint + 1] && midpoint % 2 === 0) {
      left = midpoint+2;
    } else if (nums[midpoint] === nums[midpoint - 1] && (midpoint-1)%2 === 0) {
      left = midpoint+1;
    } else if (nums[midpoint] === nums[midpoint + 1] && midpoint % 2 === 1) {
      right = midpoint-1;
    } else if (nums[midpoint] === nums[midpoint - 1] && (midpoint-1)%2 === 1) {
      right = midpoint-2;
    } else {
      return nums[midpoint];
    }
  }
}
console.log(singleNonDuplicate([1,1,2,3,3,4,4,8,8]))