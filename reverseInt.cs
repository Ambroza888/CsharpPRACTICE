using System;
using System.Collections.Generic;

namespace Csharp
{
  class revINT
  {
    public static int reverseINT(int num)
    {
      int lastdigit;
      int reverse = 0;
      while (num !=0)
      {
        lastdigit = num % 10;
        reverse = (reverse*10) + lastdigit;
        num = num/10;
      }
      return reverse;
    }
  }
}