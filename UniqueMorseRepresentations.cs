using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class UniqueMorse
  {
    public static int UniqueMorseRepresentations(string[] words)
    {
      string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
      string temp = "";
      int index = 0;
      HashSet<string> transformation = new HashSet<string>();
      for( int i = 0 ; i < words.Length; i++)
      {
        for( int j = 0; j < words[i].Length; j++)
        {
          index = words[i][j] - 97;
          temp += morse[index];
          int yo = 'd' - 97;
        }
        transformation.Add(temp);
        temp = "";
      }
      return transformation.Count;
    }
  }
}