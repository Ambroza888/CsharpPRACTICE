using System;
using System.Collections.Generic;

namespace Csharp
{
  // string = "Hi My name is Andrei" output: ierdnA si eman yM iH"
  class ReverseString
  {
    public static void ReverseSTR1(string str)
    {
      List<int> result = new List<int>();
      for(int i = str.Length-1 ; i >= 0;i--)
      {
        result.Add(str[i]);
        System.Console.WriteLine(str[i]);
      }
      foreach(var i in result){Console.WriteLine(i);}
    }
  }
}