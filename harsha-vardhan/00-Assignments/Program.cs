using System;

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

      // ac.MultipleObjectsExample();
      // Console.ReadKey();
      // Console.Clear();

      ac.NumberClass();
      Console.ReadKey();
      Console.Clear();

      ac.TypeConversion();
      Console.ReadKey();
      Console.Clear();

      ac.Constructors();
      Console.ReadKey();
      Console.Clear();
    }
  }
}
