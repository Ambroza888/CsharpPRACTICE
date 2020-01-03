using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class Palindrom_LinkedLIst
  {
    public static bool solution(MyNode head)
    {
      // first find the mid of the list
      // second reverse the second part
      // third compare with the two heads of the first part and the second part and if all the values are == execute the true;
      if(head == null || head.next == null) return false;
      MyNode fast = head;
      MyNode slow = head;
      // find mid of the LList
      while(fast.next != null && fast.next.next != null)
      {
        fast = fast.next.next;
        slow = slow.next;
      }
      // assing "secondHead" that we can compaere later
      // assinging secondHead to be == to slow. next to take care of odd/even problem of the nodes
      MyNode secondHead = slow.next;
      
      // reversing Nodes
      while(secondHead.next != null)
      {
        MyNode temp = secondHead.next;
        secondHead.next = secondHead.next.next;
        temp.next = slow.next;
        slow.
      }
      return true;
    }
  }
}