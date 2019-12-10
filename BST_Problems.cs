using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class BFS_problems
  {
    public static List<int> PreorderTraversal(TreeNode root)
    {
      List<int> result = new List<int>();
      if(root == null) return result;
      
      Stack<TreeNode> mystack = new Stack<TreeNode>();

      mystack.Push(root);
      
      while(mystack.Count > 0)
      {
        TreeNode currentNode = mystack.Pop();
        result.Add(currentNode.value);
        if(currentNode.left != null)
        {
          mystack.Push(currentNode.left);
        }
        if(currentNode.right != null)
        {
          mystack.Push(currentNode.right);
        }
      }
      return result;
    }

    public bool ValidateBST(TreeNode root)
    {
      if (root == null) return true;
      Stack<TreeNode> mystack = new Stack<TreeNode>();

      TreeNode current = root;
      TreeNode previus = null;
      
    }
  }
}