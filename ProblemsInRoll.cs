using System;
using System.Collections.Generic;

namespace Csharp
{
  class ProblemsinRoll
  {
    public IList<string> FizBuz(int n)
    {
      List<string> result = new List<string>();
      if (n < 1) return result;
      for (int i = 1; i <= n; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
          result.Add("FizzBuzz");
        else if (i % 3 == 0)
          result.Add("Fizz");
        else if (i % 5 == 0)
          result.Add("Buzz");
        else
        {
          result.Add(i.ToString());
        }
      }
      return result;
    }
    //Given a non-empty array of integers, every element appears twice except for one. Find that single one.
    //Input: [4,1,2,1,2]
    //Output: 4
    public static int SingleNumber(int[] nums)
    {
      HashSet<int> set = new HashSet<int>();
      foreach (int n in nums)
      {
        if (!set.Contains(n))
        {
          set.Add(n);
        }
        else
        {
          set.Remove(n);
        }
      }
      foreach (int i in set)
      {
        return i;
      }
      return -1;
    }
    //Given a binary tree, find its maximum depth.
    //The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    public static int MaxDepth(TreeNode root)
    {
      if (root == null) return 0;

      else
      {
        int leftDepth = 1 + MaxDepth(root.left);
        int righDepth = 1 + MaxDepth(root.right);

        return Math.Max(leftDepth, righDepth);
      }
    }
    //Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.
    // Input: a = 1, b = 2
    // Output: 3
    public static int sumTwoInt(int a , int b)
    {
        if(b == 0) return a;
        int noCarry = a ^ b;
        int carry = a & b;

        return sumTwoInt(noCarry, carry << 1);
    }
  }
}