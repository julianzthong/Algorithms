namespace Runner.Algorithms;

public partial class Solution
{
  public int IslandPerimeter(int[][] grid)
  {
    int perimeter = 0;
    if (grid.Length == 1 && grid[0].Length == 1)
    {
      return 4;
    }

    for (var y = 0; y < grid.Length; y++)
    {
      for (var x = 0; x < grid[y].Length; x++)
      {
        if (grid[y][x] == 1)
        {
          perimeter += CheckRight(grid, x, y);
          perimeter += CheckLeft(grid, x, y);
          perimeter += CheckUp(grid, x, y);
          perimeter += CheckDown(grid, x, y);
        }
      }
    }

    return perimeter;
  }

  private int CheckRight(int[][] grid, int x, int y)
  {
    if (x == grid[y].Length - 1)
    {
      return 1;
    }
    if (grid[y][x + 1] == 0)
    {
      return 1;
    }
    return 0;
  }

  private int CheckLeft(int[][] grid, int x, int y)
  {
    if (x == 0)
    {
      return 1;
    }
    if (grid[y][x - 1] == 0)
    {
      return 1;
    }

    return 0;
  }

  private int CheckUp(int[][] grid, int x, int y)
  {
    if (y == 0)
    {
      return 1;
    }
    if (grid[y - 1][x] == 0)
    {
      return 1;
    }

    return 0;
  }

  private int CheckDown(int[][] grid, int x, int y)
  {
    if (y == grid.Length - 1)
    {
      return 1;
    }
    if (grid[y + 1][x] == 0)
    {
      return 1;
    }

    return 0;
  }
}

/*

You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.

Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).

The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island. One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

Example 1:

Input: grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
Output: 16
Explanation: The perimeter is the 16 yellow stripes in the image above.

Example 2:

Input: grid = [[1]]
Output: 4

Example 3:

Input: grid = [[1,0]]
Output: 4

Constraints:

    row == grid.length
    col == grid[i].length
    1 <= row, col <= 100
    grid[i][j] is 0 or 1.
    There is exactly one island in grid.

*/