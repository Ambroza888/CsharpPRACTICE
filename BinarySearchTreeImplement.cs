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
    public TreeNode(int x)
    {
      left = null;
      right = null;
      value = x;
    }
  }
  class BinarySearchTree
  {
    public static TreeNode root;
    BinarySearchTree(){ root = null;}
    public static void insert(int value)
    {
      TreeNode newNode = new TreeNode(value);
      if(root == null)
      {
        root = newNode;
      }
    }
  }
}