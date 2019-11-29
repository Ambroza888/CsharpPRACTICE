using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class FactorailIterative
  {
    public static int solution(int num)
    {
      if(num == 2) return 2;
      int result = 1;
      for(int i = num; i > 1;i--)
      {
        result = result * i;
      }
      return result; 
    }
  }
  //recursion
  class FactorialRecursive
  {
    public static int solution(int num)
    {
      // base case
      if(num == 2) return num;
      // recusive call
      return num * solution(num-1);
    }
  }
}