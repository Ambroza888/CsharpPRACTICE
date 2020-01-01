using System;
using System.Collections.Generic;

namespace Csharp
{
  class Linked_List_cycle
  {
    public static bool solution(MyNode head)
    {
      MyNode slow = head;
      MyNode fast = head.next;

      while(slow != fast)
      {
        if(fast == null || fast.next == null) return false;
        slow = slow.next;
        fast = fast.next.next;
      }
      return true;
    }
  }
}