using System;
using System.Collections.Generic;

namespace Csharp
{
  class SLL
  {
    public static ListNode ReverseSLLlist(ListNode head)
    {
      if(head == null) return null;
      ListNode p = null;
      ListNode c = head;
      ListNode f = head.next;

      while(f != null)
      {
        c.next = p;
        p = c;
        c = f;
        f = f.next;
      }
      c.next = p;
      head = c;
      return head;
    }
  }
}