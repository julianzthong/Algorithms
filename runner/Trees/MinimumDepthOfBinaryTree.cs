namespace Runner.Trees;

public partial class Solution
{
  public int MinDepth(TreeNode root)
  {
    if (root == null)
    {
      return 0;
    }
    if (root.left == null)
    {
      return MinDepth(root.right) + 1;
    }
    if (root.right == null)
    {
      return MinDepth(root.left) + 1;
    }

    return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;
  }
}