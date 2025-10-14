namespace Runner.Algorithms;

public partial class Solution
{
  public int MaxArea(int[] height)
  {
    if (height.Length == 2)
    {
      return 1 * Math.Min(height[0], height[1]);
    }

    int result = 0;
    int first = 0;
    int next = height.Length - 1;

    while (first < next)
    {
      int length = next - first;

      result = Math.Max(result, length * Math.Min(height[first], height[next]));
      if (height[first] < height[next])
      {
        first++;
      }
      else
      {
        next--;
      }
    }

    return result;
  }
}

// [1,2]