using System;
using System.Collections.Generic;

namespace Csharp
{
  // Node
  class Node
  {
    public int value;
    public Node next; 
    public Node(int val)
    {
      value = val;
      next = null;
    }
    public Node()
    {
      value = 0;
      next = null;
    }
  }
  // STACK
  class Stack
  {
    public Node top;
    public Node bottom;
    public int length;
    public Stack()
    {

    }
    public void peek()
    {
      System.Console.WriteLine(this.top.value);
    }
  }
}