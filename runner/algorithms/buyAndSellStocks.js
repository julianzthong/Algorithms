/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
  let max = 0;
  let left = 0; // buy
  let right = 1; // sell

  while (right < prices.length) {
    if (prices[left] < prices[right]) {
      let currentProfit = prices[right] - prices[left];
      if (currentProfit > max) {
        max = currentProfit;
      }
    } else {
      left = right;
    }
    right++;
  }

  return max;
};

// Input: prices = [7,1,5,3,6,4]
// Output: 5

// Input: prices = [7,6,4,3,1]
// Output: 0