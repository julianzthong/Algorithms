/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
  let checker = {};

  for (let i = 0; i < nums.length; i++) {
    if (checker[nums[i]] == undefined) {
      checker[nums[i]] = i;
    } else {
      return true;
    }
  }

  return false;
};

console.log(containsDuplicate([1,2,3,1]));

// Input: nums = [1,2,3,1]
// Output: true

// Input: nums = [1,2,3,4]
// Output: false

// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true
