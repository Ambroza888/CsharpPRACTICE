using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class HappyNumber
  {
    public static bool HappyN(int n)
    {
      HashSet<int> myset = new HashSet<int>();

      while(true)
      {
        int newTotal = 0;
        while(n > 0)
        {
          int digit = n % 10;
          newTotal = newTotal + digit * digit;
          n = n / 10;
        }
        n = newTotal;
        if(!myset.Add(n)) return false;
        if(n == 1) return true;
      }
    }
  }
}