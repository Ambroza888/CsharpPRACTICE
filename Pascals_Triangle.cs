using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class PascalsTriangle
  {
    public static List<List<int>> Solution(int numRows)
    {
      List<List<int>> result = new List<List<int>>();
      List<int> itemList;

      for(int i = 1; i <= numRows; i ++)
      {
        itemList = new List<int>();
        for(int j = 0; j < i; j++)
        {
          if(j == 0 || j  == i -1)
          {
            itemList.Add(1);
          }
          else
          {
              itemList.Add(result[i -2][j - 1] + result[i - 2][j]);
          }
        }
        result.Add(itemList);
      }
      return result;
    }
  }
}