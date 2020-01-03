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
      return true;
    }
  }
}