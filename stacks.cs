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
      top = null;
      bottom = null;
      length = 0;
    }
    public void peek()
    {
      Console.WriteLine(this.top.value);
    }
    public void push(int value)
    {
      Node newNode = new Node(value);
      if (this.length == 0)
      {
        this.top = newNode;
        this.bottom = newNode;
      } else {
        Node holdingPointer = this.top;
        this.top = newNode;
        this.top.next = holdingPointer;
      }
      length++;
    }
  }
}