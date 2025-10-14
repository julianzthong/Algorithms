namespace Runner.Algorithms;

public partial class Solution
{
  // Inefficient
  public void MoveZeroes(int[] nums)
  {
    for (var first = 0; first < nums.Length - 1; first++)
    {
      var next = first + 1;
      while (next < nums.Length)
      {
        if (nums[first] == 0)
        {
          (nums[first], nums[next]) = (nums[next], nums[first]);
        }

        next++;
      }
    }
  }

  //Efficient
  public void EffecientMoveZeroes(int[] nums)
  {
    int lastNonZeroNumber = 0;
    for (var i = 0; i < nums.Length; i++)
    {
      if (nums[i] != 0)
      {
        if (i != lastNonZeroNumber)
        {
          (nums[i], nums[lastNonZeroNumber]) = (nums[lastNonZeroNumber], nums[i]);
        }

        lastNonZeroNumber++;
      }
    }
  }
}