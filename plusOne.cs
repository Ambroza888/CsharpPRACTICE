using System;
using System.Collections.Generic;

namespace Csharp
{
  class PlusOne
  {
    public static int[] Solution(int[] digits)
    {
      List<int> result = new List<int>();

      int carry = 0;
      int n = digits.Length;

      for(int i = n-1 ; i >= 0;i--)
      {
        int oneResult = digits[i] + carry;
        
        if(i == n -1 )
        {
          oneResult +=1;
        }
        carry = oneResult /10;
        result.Add(oneResult % 10);
      }
      if(carry != 0) result.Add(carry);
      result.Reverse();
      return result.ToArray();
    }
  }
}