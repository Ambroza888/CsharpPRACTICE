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
  class VesoStack
  {
    public Node top;
    public Node bottom;
    public int length;
    public VesoStack()
    {
      top = null;
      bottom = null;
      length = 0;
    }
    public void peek()
    {
      Node n1 = this.top;
      Node n2 = n1.next;
      Node n3 = n2.next;
      Console.WriteLine(n1.value);
      Console.WriteLine(n2.value);
      Console.WriteLine(n3.value);
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
        newNode.next = holdingPointer;
      }
      length++;
    }
    public void pop()
    {
      // this.bottom == 0 means that we don't want the bottom part be be === to the lost node;
      if (length == 0)
      {
        this.bottom = null;
      }
      Node holdingPointer = this.top;
      this.top = this.top.next;
      length--;
    }
  }
}