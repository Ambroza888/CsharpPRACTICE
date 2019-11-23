using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class TreeNode 
  {
    public int value;
    public TreeNode left;
    public TreeNode right;
    TreeNode(int x)
    {
      left = null;
      right = null;
      value = x;
    }
  }
}