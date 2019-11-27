using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class SelfDividingNumbers
  {
    public static IList<int> solution(int left, int right)
    {
      IList<int> result = new List<int>();

      while(left <= right)
      {
        int number = left;
        bool selfdeviding = true;

        if(number % 10 == 0) selfdeviding = false;
        else
        {
            while(number > 0)
            {
              int digit = number % 10;
              if(digit == 0 || left % digit !=0)
              {
                selfdeviding = false;
                break;
              }
              number = number / 10;
            }
        }
        if(selfdeviding)
        {
          result.Add(left);
        }
        left++;
      }
      return result;
    }
  }
}