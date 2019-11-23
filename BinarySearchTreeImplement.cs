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
      else
      {
          TreeNode curr = root;
          while(true)
          {
            if(value < curr.value)
            {
              //we go left
              if(curr.left == null)
              {
                curr.left = newNode;
                return;
              }
              curr = curr.left;
            }
            else
            {
                // we go right
                if(curr.right == null)
                {
                  curr.right = newNode;
                  return;
                }
                curr = curr.right;
            }
          }
      }
    }
  }
}