using System;
using System.Collections.Generic;

namespace Csharp
{
  class MaxDepthBSF
  {
        //Given a binary tree, find its maximum depth.
    //The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    public static int MaxDepth(TreeNode root)
    {
      if(root == null) return 0;

      else
      {
          int leftDepth = 1 + MaxDepth(root.left);
          int righDepth = 1 + MaxDepth(root.right);

          return Math.Max(leftDepth,righDepth);
      }
    }
  }
}