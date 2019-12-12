using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class Dynamic_Programing
  {
    //Input: [7,1,5,3,6,4]
    //Output: 5
    //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    //Not 7-1 = 6, as selling price needs to be larger than buying price.
    public static void StockMarketBruteForce(int[] prices)
    {
      int n = prices.Length;
      int maxProfit = 0;

      for(int i = 0 ; i < n-1 ; i++)
      {
        for (int j = i + 1 ; j < n; j++)
        {
          int currProf = prices[j] - prices[i];
          if(currProf > maxProfit)
          {
            maxProfit = currProf;
          }
        }
      }
      System.Console.WriteLine(maxProfit);
    }
    public static int StockMarketMaster(int[] prices)
    {
      int n = prices.Length;
      if( n == 0) return 0;
      int globalMaxProfit = 0;
      int globalMin = prices[0];

      for(int i = 1; i < n; i++)
      {
        int currPrice = prices[i];
        int localMaxProfit = Math.Max(0,currPrice - globalMin);
        globalMaxProfit = Math.Max(localMaxProfit,globalMaxProfit);
        globalMin = Math.Min(globalMin,currPrice);
      }
      return globalMaxProfit;
    }
    //You are climbing a stair case. It takes n steps to reach to the top.
    //Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    //Input: 3
    //Output: 3
    //Explanation: There are three ways to climb to the top.
    //1. 1 step + 1 step + 1 step
    //2. 1 step + 2 steps
    //3. 2 steps + 1 step
    public static int ClimbStairs(int n)
    {
      int first = 1;
      int second = 2;
      int result = 0;
      if(n < 3) return n;
      for(int i = 3; i <= n; i++)
      {
        result = first+second;
        first = second;
        second =  result;
      }
      return result;
    }
  }
}