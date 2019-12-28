using System;
using System.Collections.Generic;

namespace Csharp
{
  class SymmetricTree
  {
    public static bool Solution(TreeNode root)
    {
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      q.Enqueue(root);
      while(q.Count > 0)
      {
        TreeNode t1 = q.Dequeue();
        TreeNode t2 = q.Dequeue();
        if(t1 == null && t2 == null) continue;
        if(t1 == null || t2 == null) return false;
        if(t1.value != t2.value) return false;
        q.Enqueue(t1.left);
        q.Enqueue(t2.right);
        q.Enqueue(t1.right);
        q.Enqueue(t2.left);
      }
      return true;
    }
    public static bool RecursiveSolution(TreeNode root)
    {
      if(root == null) return true;
      return DFS(root.left,root.right);
    }
    private static bool DFS(TreeNode left, TreeNode right)
    {
      if(left == null && right == null) return true;
      if(left == null || right == null) return false;
      if(left.value == right.value)
      {
        return DFS(left.left,right.right) && DFS(left.right,right.left);
      }
      return false;
    }
  }
}