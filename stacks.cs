using System;
using System.Collections.Generic;

namespace Csharp
{
  // MyNode
  class MyNode
  {
    public int value;
    public MyNode next; 
    public MyNode(int val)
    {
      value = val;
      next = null;
    }
    public MyNode()
    {
      value = 0;
      next = null;
    }
  }
  // STACK
  class VesoStack
  {
    public MyNode top;
    public MyNode bottom;
    public int length;
    public VesoStack()
    {
      top = null;
      bottom = null;
      length = 0;
    }
    public void peek()
    {
      MyNode n1 = this.top;
      MyNode n2 = n1.next;
      MyNode n3 = n2.next;
      Console.WriteLine(n1.value);
      Console.WriteLine(n2.value);
      Console.WriteLine(n3.value);
    }
    public void push(int value)
    {
      MyNode newMyNode = new MyNode(value);
      if (this.length == 0)
      {
        this.top = newMyNode;
        this.bottom = newMyNode;
      } else {
        MyNode holdingPointer = this.top;
        this.top = newMyNode;
        newMyNode.next = holdingPointer;
      }
      length++;
    }
    public void pop()
    {
      // this.bottom == 0 means that we don't want the bottom part be be === to the lost MyNode;
      if (length == 0)
      {
        this.bottom = null;
      }
      MyNode holdingPointer = this.top;
      this.top = this.top.next;
      length--;
    }
  }
}