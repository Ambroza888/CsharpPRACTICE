using System;
using System.Collections.Generic;

namespace Csharp
{
  class CrazyQueue
  {
    static Stack<int> s1 = new Stack<int>();
    static Stack<int> s2 = new Stack<int>();
    public static void Enqueue(int value)
    {
      for(int i = 0; i < s1.Count; i++)
      {
        s2.Push(s1.Pop());
      }
      s2.Push(value);
    }
    public static void peeking(){
      foreach(var i in s1){System.Console.WriteLine(i);}
    }
    public static void Dequeue()
    {
      for(int j = 0; j <= s2.Count+1; j++)
      {
        s1.Push(s2.Pop());
      }
      s1.Pop();
    }
  }
  class AnotherCrazyQ
  {
    static Stack<int> s1;
    static Stack<int> s2;
    static int size;
    public AnotherCrazyQ()
    {
      s1 = new Stack<int>();
      s2 = new Stack<int>();
      size = 0;
    }
    public void Enqueue(int value)
    {
      s1.Push(value);
      size++;
    }
    public int Dequeue()
    {
      while(size > 1)
      {
        s2.Push(s1.Pop());
        size--;
      }
      int result = s1.Pop();
      size--;

      while(s2.Count > 0)
      {
        s1.Push(s2.Pop());
        size++;
      }
      return result;
    }
    public void peeking()
    {
      while(size > 1)
      {
        s2.Push(s1.Pop());
        size--;
      }
      int result = s1.Peek();
      while(s2.Count > 0)
      {
        s1.Push(s2.Pop());
        size++;
      }
      Console.WriteLine(result);
    }
  }
}