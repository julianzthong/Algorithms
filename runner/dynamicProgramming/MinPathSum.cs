namespace DynamicProgramming;

public partial class Solution
{
  public int MinPathSum(int[][] grid)
  {
    int rows = grid.Length;
    int cols = grid[0].Length;

    int[] dp = new int[cols];

    // initialize the 2D row
    dp[0] = grid[0][0];
    for (var col = 1; col < cols; col++)
    {
      dp[col] = dp[col-1] + grid[0][col];
    }

    for (var row = 1; row < rows; row++)
    {
      dp[0] += grid[row][0];
      for (var col = 1; col < cols; col++)
      {
        dp[col] = grid[row][col] + Math.Min(dp[col], dp[col - 1]);
      }
    }

    return dp[cols-1];
  }
}

/*
Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.

Example 1:

Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.

Example 2:

Input: grid = [[1,2,3],[4,5,6]]
Output: 12

*/
