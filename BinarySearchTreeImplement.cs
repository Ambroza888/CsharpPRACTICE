using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  public class TreeNode 
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
  public class BinarySearchTree
  {
    public TreeNode root;
    public BinarySearchTree()
    {
      root = null;
    }
    public void insert(int value)
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
    public bool lookup(int value)
    {
      if(root == null) return false;
        TreeNode curr = root;
        while(curr != null)
        {
          if(value < curr.value)
          {
            curr = curr.left;
          }
          else if(value > curr.value)
          {
            curr = curr.right;
          }
          else if(value == curr.value) 
          {
            System.Console.WriteLine(true);
            return true;
          }
        }
        System.Console.WriteLine(false);
        return false;
    }
    // -------------------------------------------------------------------------
    // BreadthFirstSearch (BFS)
    // -------------------------------------------------------------------------
    public void BreadthFirstSearch()
    {
      TreeNode currentNode = root;
      Queue<TreeNode> myQ = new Queue<TreeNode>();
      List<int> result = new List<int>();

      myQ.Enqueue(currentNode);

      while(myQ.Count > 0)
      {
        currentNode = myQ.Dequeue();
        result.Add(currentNode.value);
        if(currentNode.left != null)
        {
          myQ.Enqueue(currentNode.left);
        }
        if(currentNode.right != null)
        {
          myQ.Enqueue(currentNode.right);
        }
      }
      foreach(var i in result){Console.Write($"{i},");}
    }
    public List<int> BreadthFirstSearchRecursive(Queue<TreeNode> myQ, List<int> result)
    {
      if(myQ.Count == 0)
      {
        return result;
      }
      TreeNode currNode = myQ.Dequeue();
      result.Add(currNode.value);
      if(currNode.left != null)
      {
        myQ.Enqueue(currNode.left);
      }
      if(currNode.right !=null)
      {
        myQ.Enqueue(currNode.right);
      }
      return BreadthFirstSearchRecursive(myQ,result);
    }
    // -------------------------------------------------------------------------
    // DepthFirstSerach (D)
    // -------------------------------------------------------------------------
    public List<int> DPSInorder()
    {
      List<int> list = new List<int>();
      return TraverseInOrder(root, list);
    }
    public List<int> DPSPPostorder()
    {
      List<int> list = new List<int>();
      return TraversePostOrder(root, list);
    }
    public List<int> DPSPreorder()
    {
      List<int> list = new List<int>();
      return TraversePostOrder(root, list);
    }

    public List<int> TraverseInOrder(TreeNode node, List<int> list)
    {
      if(node.left != null)
      {
        TraverseInOrder(node.left, list);
      }
      list.Add(node.value); 

      if(node.right != null)
      {
        TraverseInOrder(node.right,list);
      }
      return list;
    }
    public List<int> TraversePostOrder(TreeNode node, List<int> list)
    {
      list.Add(node.value); 
      if(node.left != null)
      {
        TraversePostOrder(node.left, list);
      }
      if(node.right != null)
      {
        TraversePostOrder(node.right,list);
      }
      return list;
    }
    public List<int> TraversePreOrder(TreeNode node, List<int> list)
    {

      if(node.left != null)
      {
        TraversePreOrder(node.left, list);
      }
      if(node.right != null)
      {
        TraversePreOrder(node.right,list);
      }
      list.Add(node.value); 
      return list;
    }

    public bool ValidateBST()
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
  }
}