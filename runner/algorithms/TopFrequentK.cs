namespace Runner.Algorithms;

public partial class Solution
{
  public int[] TopKFrequent(int[] nums, int k)
  {
    Dictionary<int, int> counts = [];
    for (int i = 0; i < nums.Length; i++)
    {
      if (counts.TryGetValue(nums[i], out int value))
      {
        counts[nums[i]] = ++value;
      }
      else
      {
        counts[nums[i]] = 1;
      }
    }

    //Heap
    PriorityQueue<int,int> heap = new();

    foreach (var (num, freq) in counts)
    {
      heap.Enqueue(num, freq);
    }

    while (heap.Count > k)
    {
      heap.Dequeue();
    }

    return [.. heap.UnorderedItems.Select(x => x.Element)];
  }
}