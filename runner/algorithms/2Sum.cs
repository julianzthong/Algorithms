namespace Runner.Algorithms;

public partial class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    int next = 1;
    int length = nums.Length;

    for (var first = 0; first < next; first++)
    {
      while (next < length)
      {
        if (nums[first] + nums[next] == target)
        {
          return [first, next];
        }

        next++;
      }

      next = first + 1;
    }

    return [];
  }
}

// [3,2,4], 6