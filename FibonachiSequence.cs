using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class Fibonacci
  {
    public static int fibonacciRecursive(int n)
    {
      if(n < 2){
        return n;
      }
      return fibonacciRecursive(n-1) + fibonacciRecursive(n-2); 
    }

  }
}