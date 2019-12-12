using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class Dynamic_Programing
  {
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
  }
}