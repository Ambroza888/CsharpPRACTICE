using System;
using System.Collections.Generic;

namespace Csharp
{
  class reverseStrDollarSign
  {
    public static string reverseSTR(string str)
    {
      char[] word = str.ToCharArray();
      int left = 0;
      int right = word.Length-1;
      while (left < right)
      {
        if(!char.IsLetter(word[left]))
        {
          left++;
        }
        if(!char.IsLetter(word[right]))
        {
          right--;
        }
        else
        {
            char temp = word[left];
            word[left] = word[right];
            word[right] = temp;
            left++;
            right--;
        }
      }
      return word.ToString();
    }
  }
}