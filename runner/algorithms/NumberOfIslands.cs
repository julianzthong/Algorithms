namespace Runner.Algorithms;

public partial class Solution {
  public static int NumIslands(char[][] grid) {
    int islands = 0;

    for (var row = 0; row < grid.Length; row++)
    {
      for (var col = 0; col < grid[row].Length; col++)
      {
        if (grid[row][col] == '0')
        {
          continue;
        }

        if (grid[row][col] == '1')
        {
          islands++;

          DFS(grid, row, col);
        }
      }
    }

    return islands;
  }

  public static void DFS(char[][] grid, int row, int col)
  {
    if (!ValidCoords(grid, row, col) || grid[row][col] == '0')
    {
      return;
    }

    grid[row][col] = '0';

    DFS(grid, row - 1, col);
    DFS(grid, row + 1, col);
    DFS(grid, row, col + 1);
    DFS(grid, row, col - 1);
  }

  public static void BFS(char[][] grid, int row, int col)
  {
    if (!ValidCoords(grid, row, col) || grid[row][col] == '0')
    {
      return;
    }

    Queue<(int, int)> queue = new();

    _ = queue.Append((row, col));

    if (queue.Count > 0)
    {

    }

  }

  public static void Explore(Queue<(int, int)> queue, char[][] grid, int row, int col)
  {

  }

  public static bool ValidCoords(char[][] grid, int row, int col)
  {
    if (row < 0 || row >= grid.Length) return false;
    if (col < 0 || col >= grid[row].Length) return false;

    return true;
  }
}

/*
Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1

Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3

Constraints:

    m == grid.length
    n == grid[i].length
    1 <= m, n <= 300
    grid[i][j] is '0' or '1'.
*/