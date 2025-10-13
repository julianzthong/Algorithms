/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.

Example 1:
Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1

Example 2:
Input: coins = [2], amount = 3
Output: -1

Example 3:
Input: coins = [1], amount = 0
Output: 0

Example 4:
Input: coins = [1], amount = 1
Output: 1

Example 5:
Input: coins = [1], amount = 2
Output: 2


Constraints:

1 <= coins.length <= 12
1 <= coins[i] <= 231 - 1
0 <= amount <= 104
*/

/**
 * @param {number[]} coins
 * @param {number} amount
 * @return {number}
 */
var coinChange = function (coins, amount, memo = {}) {
  const findCombo = (coins, amount, memo = {}) => {
    if (amount in memo) return memo[amount];
    if (amount === 0) {
      return [];
    }
    if (amount < 0) {
      return -1;
    }
    let shortestCombination = -1;

    for (let coin of coins) {
      const remainder = amount - coin;
      const remainderCombination = findCombo(coins, remainder, memo);
      if (remainderCombination !== -1) {
        const combination = [...remainderCombination, coin];
        if (
          combination.length < shortestCombination.length ||
          shortestCombination === -1
        ) {
          shortestCombination = combination;
        }
      }
    }
    memo[amount] = shortestCombination;
    return memo[amount];
  };
  const combo = findCombo(coins, amount, memo);
  return combo.length;
};

// console.log(coinChange([1, 2, 5], 11));
// console.log(coinChange([1, 2, 5, 25], 100));

const coinChangeTab = (coins, amount) => {
  const table = Array(amount + 1).fill(-1);
  table[0] = [];

  for (let i = 0; i <= amount; i++) {
    if (table[i] != -1) {
      for (let coin of coins) {
        const combination = [ ...table[i], coin ];
        if (i + coin <= amount) {
          if (table[i + coin] === -1 || combination.length < table[i + coin].length) {
            table[i + coin] = combination;
          }
        }
      }
    }
  }
  if(table[amount] !== -1) {
    return table[amount].length;
  }
  return table[amount];
}

console.log(coinChangeTab([1, 2, 5, 25], 100));
