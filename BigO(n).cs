using System;
using System.Collections.Generic;

namespace Csharp
{
  class BigOn
  {
    public static int Summ(int n)
    {
      if( n <= 0)
      {
        return 0;  
      } 
      return n + Summ(n-1);
    } 
  }
}