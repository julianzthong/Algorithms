namespace DynamicProgramming;

public partial class Solution
{
  public IList<IList<int>> Generate(int numRows)
  {
    List<IList<int>> row = [[1]];
    if (numRows == 1)
    {
      return row;
    }

    row.Add([1, 1]);
    if(numRows == 2)
    {
      return row;
    }

    for (var i = 2; i < numRows; i++)
    {
      List<int> newRow = [];
      for (var j = 0; j < i + 1; j++)
      {
        if (j == 0 || j == i)
        {
          newRow.Add(1);
        }
        else
        {
          newRow.Add(row[i - 1][j - 1] + row[i - 1][j]);
        }
      }
      row.Add(newRow);
    }

    return row;
  }
}

/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:



Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

Example 2:

Input: numRows = 1
Output: [[1]]



Constraints:

    1 <= numRows <= 30

*/