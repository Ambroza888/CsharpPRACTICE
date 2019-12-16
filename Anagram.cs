using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  //Input: s = "anagram", t = "nagaram"
  //Output: true
  //===================================
  //Input: s = "rat", t = "car"
  //Output: false
  class Anagram
  {
    public static bool Solution(string s, string t)
    {
      if(s.Length != t.Length) return false;
      Dictionary<char,int> d = new Dictionary<char, int>();

      foreach(char letter in s)
      {
        if(!d.ContainsKey(letter))
        {
          d.Add(letter, 1);
        }
        else
        {
            d[letter]++;
        }
      }

      foreach( char letter in t)
      {
        if(d.ContainsKey(letter))
        {
          if(d[letter] > 1)
          {
            d[letter]--;
          }
          else
          {
              d.Remove(letter);
          }
        }
        else
        {
            return false;
        }
      }
      return d.Keys.Count == 0;
    }
  }
}