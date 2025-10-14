namespace Runner.Algorithms;

public partial class Solution
{
  public int MaxArea(int[] height)
  {
    if (height.Length == 2)
    {
      return 1 * Math.Min(height[0], height[1]);
    }
    var next = height.Length - 1;
    int length = height.Length;
    int result = 0;
    for (var first = 0; first < next; first++)
    {
      while (first < next)
      {
        length--;

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
    }

    return result;
  }
}

// [1,2]