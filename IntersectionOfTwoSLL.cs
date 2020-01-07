using System;
using System.Collections.Generic;

namespace Csharp
{
  class IntersectionOfTwoSLL
  {
    public static MyNode Solution(MyNode headA, MyNode headB)
    {
      if(headA == null || headB == null) return null;

      MyNode rA = headA;
      MyNode rB = headB;

      int countA  = 0;
      while(rA != null)
      {
        countA ++;
        rA = rA.next;
      }

      int countB = 0;
      while(rB != null)
      {
        countB++;
        rB = rB.next;
      }
      int diff = Math.Abs(countA - countB);
      rA = headA;
      if(countA > countB)
      {
        while(diff > 0)
        {
          qweqwe
        }
      }

    }
  }
}