using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class Fibonacci
  {
    //recursive 
    // Exponential Time  -------> O(2^N) <--------
    public static int fibonacciRecursive(int n)
    {
      if(n < 2){
        return n;
      }
      return fibonacciRecursive(n-1) + fibonacciRecursive(n-2); 
    }
    // iterative
    //  -------------> O(n) <------------------
    public static int fibIterative(int n)
    {
      List<int> result = new List<int>(){1,2};
      for(int i = 2; i <= n; i++)
      {
        result.Add(result[i-2] + result[i-1]);
      }
      return result[n];
    }
  }
}