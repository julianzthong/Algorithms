namespace Runner.Algorithm;

public partial class Solution
{
  public IList<IList<int>> ThreeSum(int[] nums)
  {
    Array.Sort(nums);
    IList<IList<int>> result = [];
    if (nums.Length < 3)
    {
      return [];
    }

    for (int first = 0; first < nums.Length - 2; first++)
    {
      if (first > 0 && nums[first] == nums[first - 1])
      {
        continue;
      }

      int next = first + 1;
      int last = nums.Length - 1;

      while (next < last)
      {
        int sum = nums[first] + nums[next] + nums[last];
        if (sum == 0)
        {
          result.Add([nums[first], nums[next], nums[last]]);

          while (next < last && nums[next] == nums[next + 1])
          {
            next++;
          }

          while (next < last && nums[last] == nums[last - 1])
          {
            last--;
          }

          next++;
          last--;
        }
        else if (sum < 0)
        {
          next++;
        }
        else
        {
          last--;
        }
      }
    }

    return result;
  }
}

/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Example 1:
Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]

Example 2:
Input: nums = []
Output: []

Example 3:
Input: nums = [0]
Output: []

Constraints:

0 <= nums.length <= 3000
-105 <= nums[i] <= 105
*/