﻿using System;

namespace _00_Assignments
{
  class Program
  {
    static void Main(string[] args)
    {
      AssignmentsClass ac = new AssignmentsClass();
      Console.WriteLine("Basics:");
      ac.AreaOfCircle();
      ac.FeetToCm();
      ac.NearestThousand();
      ac.TimeCalculator();
      ac.HeightCategory();
      ac.LargestNumber();
      ac.PatternPrinting();
      Console.ReadKey();
      Console.Clear();
    }
  }
}
