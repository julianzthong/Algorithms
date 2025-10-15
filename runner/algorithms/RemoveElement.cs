namespace Runner.Algorithms;

public partial class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    int lastIndex = 0;
    for (var i = 0; i < nums.Length; i++)
    {
      if (nums[i] != val)
      {
        nums[lastIndex] = nums[i];
        lastIndex++;
      }
    }

    return lastIndex;
  }
}