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
      while(true)
      {
        while(current != null)
        {
          mystack.Push(current);
          current = current.left;
        }
        
        if(mystack.Count == 0)
        {
          break;
        }
        current = mystack.Pop();

        if(previus != null && previus.value >= current.value)
        {
          return false;
        }
        previus = current;
        current = current.right;
      }
      return true;
    }
    public static TreeNode ConvertSortedArrayInBST(int[] nums)
    {
      if(nums.Length == 0) return null;
      return BFS_BST(nums, 0 , nums.Length-1);
    }
    private static TreeNode BFS_BST(int[] nums, int left, int right)
    {
      if(left > right) return null;
      int mid = left + (right - left);
      TreeNode current = new TreeNode(nums[mid]);
      current.left = BFS_BST(nums,left,mid-1);
      current.right = BFS_BST(nums,mid+1,right);
      return current;
    }
  }
}