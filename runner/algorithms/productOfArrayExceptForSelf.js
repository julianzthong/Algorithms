/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function(nums) {
  // Brute Force Method
  // let result = [];

  // for (let i = 0; i < nums.length; i++) {
  //   let x = 1;
  //   for (let j = 0; j < nums.length; j++) {
  //     if (i == j) {
  //       continue;
  //     }

  //     x *= nums[j];
  //   }

  //   result[i] = x;
  // }

  // return result;

  // DP Tabulation

  const n = nums.length;
  let result = Array(n);
  let leftProd = Array(n);
  let rightProd = Array(n);

  leftProd[0] = 1;
  for (let i = 1; i < n; i++) {
    leftProd[i] = leftProd[i-1] * nums[i-1];
  }

  rightProd[n - 1] = 1;
  for (let i = (n - 2); i >= 0; i--) {
    rightProd[i] = rightProd[i+1] * nums[i+1];
  }

  for (let i = 0; i < n; i ++) {
    result[i] = leftProd[i] * rightProd[i];
  }

  // DP Space Optimization
  // const length = nums.length;
  // const result = new Array(length).fill(1);

  // let productBefore = 1;
  // for (let i = 0; i < length; i++) {
  //   result[i] *= productBefore;
  //   productBefore *= nums[i];
  // }

  // let productAfter = 1;
  // for (let i = length - 1; i >= 0; i--) {
  //   result[i] *= productAfter;
  //   productAfter *= nums[i];
  // }

  return result;
};

console.log(productExceptSelf([1,2,3,4]))
console.log(productExceptSelf([-1,1,0,-3,3]))

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]

// Input: nums = [-1,1,0,-3,3]
// Output: [0,0,9,0,0]
