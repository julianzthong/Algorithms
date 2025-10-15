namespace Runner.Algorithms;

public partial class Solution
{
    // Brute Force
    // public void SortColors(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length - 1; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             if (nums[i] > nums[j])
    //             {
    //                 (nums[i], nums[j]) = (nums[j], nums[i]);
    //             }
    //         }
    //     }
    // }

    // Two pointer
  public void SortColors(int[] nums) {
    int front = 0;
    int end = nums.Length - 1;

    for (var i = 0; i < end; i++)
    {
      if (nums[i] == 0)
      {
        (nums[i], nums[front]) = (nums[front], nums[i]);
        front++;
      }
      else if (nums[i] == 2)
      {
        (nums[i], nums[end]) = (nums[end], nums[i]);
        end--;
        i--;
      }
    }
  }
}