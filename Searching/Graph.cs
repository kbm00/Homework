using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    internal class Graph
    {
        bool[,] MatrixGraph = new bool[8, 8]
         {
          {false, false,  true, false,  true, false, false, false},
          {false, false,  true, false, false,  true, false, false},
          { true,  true, false, false, false,  true,  true, false},
          {false, false, false, false, false ,false, false, true },
          { true, false, false, false, false, false, false, true },
          {false,  true,  true, false, false, false, false, false},
          {false, false,  true, false, false, false, false, false},
          {false, false, false,  true,  true, false, false, false},
         };

        bool[,] MatrixGraph2 = new bool[8, 8]
     {
          {false, false, false, false, false, false, false, false},
          {false, false, false, false, false, false, false, false},
          {false, false, false, false,  true,  true, false, false},
          {false,  true, false, false, false,  true, false, true },
          {false, false, false, false, false, false, false, false},
          {false,  true, false, false, false, false, false, false},
          {false, false,  true, false, false,  true, false, false},
          {false, false, false, false, false, false,  true, false},
     };
         
        const int INF = int.MaxValue;
        int[,] MatrixGraph3 = new int[8, 8]
       {
            {  0,   4, INF, INF,   6, INF, INF, INF},
            {  4,   0,   5,   4, INF,   8,   2, INF},
            {INF,   5,   0, INF,   9, INF, INF, INF},
            {INF,   4, INF,   0, INF, INF, INF, INF},
            {  6, INF,   9, INF,  0,  INF,   5, INF},
            {INF,   8, INF, INF, INF,   0, INF,   1},
            {INF,   2, INF, INF,   5, INF,   0, INF},
            {INF, INF, INF, INF, INF,   1, INF,   0},
       };

        


    }
}
