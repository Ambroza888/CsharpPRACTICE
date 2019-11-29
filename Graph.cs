using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  // Undirected - Unweighted - Cyclic Graph
  class myGraph
  {
    public int numberOfNodes;
    public Dictionary<string,List<string>> adjacentList;
    public myGraph()
    {
      numberOfNodes = 0;
      adjacentList = new Dictionary<string, List<string>>();
    }
    public void addVertex(string node)
    {
      List<string> list = new List<string>();
      adjacentList[node] = list;
      numberOfNodes++;
    }
    public void addEdge(string node1, string node2)
    {
      adjacentList[node1].Add(node2);
      //because is undirected i have to connect it other way around (5)-----(1000) /// (5)<----->(1999) - directed
      adjacentList[node2].Add(node1);
    }
  }
}