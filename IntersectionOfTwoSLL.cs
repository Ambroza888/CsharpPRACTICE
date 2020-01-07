using System;
using System.Collections.Generic;

namespace Csharp
{
  class IntersectionOfTwoSLL
  {
    public static MyNode Solution(MyNode headA, MyNode headB)
    {
      // I am going to run two runners from the begging to the end and find lenght of one SSL
      // The way i will do it will run a runner to the end with counter and find the length of the both lists;
      // after i find the length i will find the diffrent between the two lists and i will use the absolute method ABS
      //because if A or b list is bigger i don't need negative number
      // having the counterA and counterB know which list is longer and i will let runner go WHILE the diff == 0 
      // after the runnerA or runnerB run to the node x-times i will have runnerA and ruunerB on equal distans
      // covering the part with that if they don't get crossed will cover with statement if runnerA != runnerB
      // let's do it !!!!! :))))
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
      rB = headB;

      if(countA > countB)
      {
        while(diff > 0)
        {

        }
      }

    }
  }
}