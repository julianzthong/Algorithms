namespace Runner.Algorithms;

public partial class Solution
{
  public int[] BruteForceSortedSquares(int[] nums)
  {
    int length = nums.Length;
    if (length == 1)
    {
      return [nums[0] * nums[0]];
    }
    for (int i = 0; i < length; i++)
    {
      nums[i] = nums[i] * nums[i];
    }

    for (var next = 1; next < length; next++)
    {
      for (var first = 0; first < next; first++)
      {
        if (nums[first] > nums[next])
        {
          (nums[first], nums[next]) = (nums[next], nums[first]);
        }
      }
    }

    return nums;
  }

  public int[] TwoPointerSortedSquares(int[] nums)
  {
    var length = nums.Length;
    int[] result = new int[length];
    var left = 0;
    var right = length - 1;
    var index = length - 1;

    while (left <= right)
    {
      int leftVal = nums[left] * nums[left];
      int rightVal = nums[right] * nums[right];

      if (leftVal > rightVal)
      {
        result[index--] = leftVal;
        left++;
      }
      else
      {
        result[index--] = rightVal;
        right--;
      }
    }

    return result;
  }
}

/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].

Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]

Constraints:

    1 <= nums.length <= 104
    -104 <= nums[i] <= 104
    nums is sorted in non-decreasing order.
*/