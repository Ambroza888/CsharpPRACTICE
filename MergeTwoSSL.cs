using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x){ val = x; }
  }

  class MergeTwoLists
  {
    public static ListNode Solution(ListNode l1, ListNode l2)
    {
      ListNode DummyNode = new ListNode(0);
      ListNode curr = DummyNode;
      ListNode p1 = l1;
      ListNode p2 = l2;
      while(p1 != null && p2 != null)
      {
        if(p1.val < p2.val)
        {
          curr.next = p1;
          p1 = p1.next;
        }
        else
        {
            curr.next = p2;
            p2 = p2.next;
        }
        curr = curr.next;
      }
      if(p1 !=null)
      {
        curr.next = p1;
      }
      else
      {
        curr.next = p2;
      }
      return DummyNode.next;
    }
  }
}