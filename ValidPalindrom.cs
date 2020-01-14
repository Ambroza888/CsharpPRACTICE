using System;
using System.Collections.Generic;

namespace Csharp
{
  class ValidPalindrom
  {
    public static bool Solution(string s)
    {
      int L = 0, R = s.Length-1;

      while(L <= R)
      {
        //Both First Element Match ... just keep going with incrementing and closing the gap;
        if(s[L] == s[R])
        {
          L++; R--;
        }
        else
        {
          //Removing left
          int LL = L + 1, LR = R;
          while(LL <= LR && s[LL] == s[LR])
          {
            LL++; LR--;
          }
          if(LL >= LR) return true;

          //Removing Right
          int RL = L, RR = R-1;
          while(RL <= RR && s[RL] == s[RR])
          {
            RL++; RR--;
          }
          if(RL >= RR) return true;
        }
      }
      return true;
    }

    //Palindrom TWO !
    //Input: "A man, a plan, a canal: Panama"
    //Output: true
    public static bool Solution2(string s)
    {
      if(s.Length == 0) return true;
      if(s.Length == 1) return true;

      int left = 0;
      int right = s.Length-1;
      while(left < right)
      {
        if(!char.IsLetterOrDigit(s[left]))
        {
          left++;
        }
        else if(!char.IsLetterOrDigit(s[right]))
        {
          right--;
        }
        else
        {
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
              return false;
            }
            left++;
            right--;
        }
      }
        return true;
    }
    

  }
}