using System;
using System.Collections.Generic;

namespace Csharp
{
  // string = "Hi My name is Andrei" output: ierdnA si eman yM iH"
  class ReverseString
  {
    public static string ReverseSTR1(string str)
    {
      List<int> result = new List<int>();
      for(int i = str.Length-1 ; i >= 0;i--)
      {
        result.Add(str[i]);
        System.Console.WriteLine(str[i]);
      }
      foreach(var j in result){Console.WriteLine(j);}
      return result.ToString();
    }
    public static void reverseString3(string str)
    {
      char[] s = str.ToCharArray();
      int left = 0;
      int right = s.Length-1;
      char temp;
      while(left< right)
      {
        temp = s[left];
        s[left] = s[right];
        s[right] = temp;
        left++;
        right--;
      }
    }
    public static void ReverseStringUsingStacks(string str)
    {
      char[] s = str.ToCharArray();
      Stack<char> mystack = new Stack<char>();
      for (int i = 0; i < s.Length;i++)
      {
        mystack.Push(s[i]);
      }
      for(int i = 0; i < s.Length;i++)
      {
        s[i] = mystack.Pop();
      }
      foreach(var i in s){Console.Write(i);}
    }
    // -------------------------------------------------------------------------
    // Recursive way to do it. O(2^n)
    // -------------------------------------------------------------------------
    public void RevStrRecursive(string str)
    {
      char[] s = str.ToCharArray();
      HelpFRec(s, 0 , s.Length-1);
    }
    public static void HelpFRec(char[] s, int start , int end)
    {
      if(start < end)
      {
        char temp = s[start];
        s[start] = s[end];
        s[end] = temp;
        HelpFRec(s, start+1, end-1);
      }
    }
  }
}