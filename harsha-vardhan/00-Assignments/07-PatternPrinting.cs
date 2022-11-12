﻿/*
Write a C# program to print the following output:
    1 2 3 4 7 8 9 10
    1 2 3 4 7 8 9 10
    1 2 3 4 7 8 9 10
    10 9 8 7 6 5 4 3 2 1
    10 9 8 7 6 5 4 3 2 1
    10 9 8 7 6 5 4 3
    10 9 8 7 6 5 4 3 2 1
    1 2 3 4 5 6 7 9 10

Each number should be printed by using the loop variable.
Don't print full line at-a-time as string.
For example, don't write statements as:
`System.Console.WriteLine("1 2 3 4 7 8 9 10");`

Use for loop, break and continue statements to bring the output.
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void PatternPrinting()
    {
      Console.WriteLine("PatternPrinting:");
      for (int i = 0; i < 3; i++)
      {
        // Print a line with 1 to 10 numbers (except 5 and 6)
        for (int j = 1; j < 11; j++)
        {
          // skip numbers 5 and 6 in line 1, 2, 3
          if (j == 5 || j == 6) continue;
          Console.Write(j + " ");
        }
        Console.WriteLine();
      }

      // loop for line 4, 5, 6, 7, 8
      for (int i = 0; i < 5; i++)
      {
        // print 10 to 1 numbers in line 4, 5, 6, 7, 8
        for (int j = 10; j >= 1; j--)
        {
          if (i == 2) // line 6
          {
            // skip numbers 2 and 1 in line 6
            if (j == 2 || j == 1) continue;
          }

          if (i == 4) // line 8
          {
            // skip output '8' in line 8
            if (j == 3) continue;
            // print '1' instead of '10'; '2' instead of '11' and so on up to '10' instead of '1'.
            Console.Write((11 - j) + " "); continue;
          }

          // line 4, 5, 7
          Console.Write(j + " ");
        }
        Console.WriteLine();
      }
    }
  }
}