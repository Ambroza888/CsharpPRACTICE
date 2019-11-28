using System;
using System.Collections.Generic;

namespace Csharp
{
  // intput: 28 ===> output : True \\ 28 = 1+2+4+7+14;
  class PerfectNumber
  {
    //Brute force
    public static bool solution(int num)
    {
      if(num <= 0) return false;
      int sum = 0;
      for(int i = 1; i < num ; i++)
      {
        if(num%i == 0) sum+=i;
        if(sum > num) return false;
      }
      return sum == num;
    }
    //Optimal solution
    public static bool optimalsolution(int num)
    {
      if(num <= 0) return false;
      int sum = 0;
      for(int i = 1 ; i < num;i++)
      {
        if(num % i ==0)
        {
          sum = sum + i;
          if(i * i !=num)
          {
            sum = sum + num/i;
          }
        }
      }
      return sum - num == num;
    }
  }
}