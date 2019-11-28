using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  // Undirected - Unweighted - Cyclic Graph
  class myGraph
  {
    public int numberOfNodes;
    public Dictionary<string,Array> adjacentList;
    public myGraph()
    {
      numberOfNodes = 0;
      adjacentList = new Dictionary<string, Array>();
    }
    public addVertex(string node)
    {
      string[] arr = new string[]{};
      adjacentList[node] = arr;
    }
  }
}