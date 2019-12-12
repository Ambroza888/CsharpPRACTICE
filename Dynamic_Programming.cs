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
  }
}