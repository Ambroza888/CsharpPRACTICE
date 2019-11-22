using System;
using System.Collections.Generic;
using System.Text;
namespace Csharp
{
  class RemoveOuter
  {
    public static void o(string S)
    {
      string result = "";
      int count = 0;
      for(int i = 0; i < S.Length;i++)
      {
        if (S[i] == '(')
        {
          if(count > 0)
          {
            result+= S[i];
          }
          count++;
        }
        else
        {
            count--;
            if(count > 0)
            {
              result+= S[i];
            }
        }
      }
      System.Console.WriteLine(result);
    }
  }
}