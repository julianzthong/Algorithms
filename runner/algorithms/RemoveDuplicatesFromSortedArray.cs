namespace Runner.Algorithms;

public partial class Solution
{
  // modifies nums and returns number of unique ints
  public int RemoveDuplicates(int[] nums)
  {
    if (nums.Length == 0) return 0;
    int lastNonDupeIndex = 1;
    for (var i = 1; i < nums.Length; i++)
    {
      if (nums[i - 1] != nums[i])
      {
        nums[lastNonDupeIndex] = nums[i];
        lastNonDupeIndex++;
      }
    }

    return lastNonDupeIndex;
  }
}