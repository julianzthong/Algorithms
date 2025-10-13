public class Solution
{
  public IList<int> SpiralOrder(int[][] matrix)
  {
    List<int> result = new();
    var top = 0;
    var bottom = matrix.Length - 1;
    var left = 0;
    var right = matrix[0].Length - 1;

    while (top <= bottom && left <= right)
    {
      for (var i = left; i <= right; i++)
      {
        result.Add(matrix[top][i]);
      }
      top++;

      for (var j = top; j <= bottom; j++)
      {
        result.Add(matrix[j][right]);
      }
      right--;

      if (top <= bottom)
      {
        for (var k = right; k >= left; k--)
        {
          result.Add(matrix[bottom][k]);
        }
        bottom--;
      }

      if (left <= right)
      {
        for (var l = bottom; l >= top; l--)
        {
          result.Add(matrix[l][left]);
        }
        left++;
      }
    }

    return result;
  }
}

/*
54. Spiral Matrix
Given an m x n matrix, return all elements of the matrix in spiral order.

Example 1:

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]

Example 2:

Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]

Constraints:

    m == matrix.length
    n == matrix[i].length
    1 <= m, n <= 10
    -100 <= matrix[i][j] <= 100

*/